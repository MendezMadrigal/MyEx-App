using Android.App;
using Android.Content;
using Android.Gms.Extensions;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using Firebase.Firestore;
using Java.Interop;
using Java.Util;
using MyEx.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;


[assembly: Dependency(typeof(MyEx.Droid.Dependencies.Register))]
namespace MyEx.Droid.Dependencies
{
    public class Register : Java.Lang.Object, IRegister, IOnCompleteListener
    {
        bool UserNameOrinalityStatement;
        string name;

       

        public async Task<bool> RegisterUser(string email, string password, string username, string gender)
        {
            try
            {
                await Firebase.Auth.FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);//here we register the user in the authenticate section of firestore.
                InsertUserData(username, gender);
                return true;
            }
            catch (FirebaseAuthWeakPasswordException error)
            {
                throw new Exception("La contraseña debe tener al menos 6 caracteres");
            }
            catch (Java.Lang.IllegalArgumentException error)
            {
                throw new Exception("Ingrese todos los datos solicitados correctamente.");
            }
            catch (Firebase.Auth.FirebaseAuthInvalidCredentialsException)
            {
                throw new Exception("El correo electrónico no es reconocido.");
            }
            catch (Exception error)
            {
                throw new Exception(error.GetType().ToString());
            }
        }//end Register User

        

        private void InsertUserData(string userName, string gender)//with this method we send the data that the user register to the data base.
        {
            var userDataDocument = new Dictionary<String, Java.Lang.Object>
            {
                { "userName", userName },
                { "gender", gender },
                { "userID", Firebase.Auth.FirebaseAuth.Instance.CurrentUser.Uid },
            };

            var collection = Firebase.Firestore.FirebaseFirestore.Instance.Collection("userData");
            collection.Add(new HashMap(userDataDocument));

        }//end InserUserData



        public async Task<bool> userNameOriginality(string userName)//with this method we verify that the userName doesn't already exist.
        {
            UserNameOrinalityStatement = true; //at first, the userName is selected as  original, if this statement is false, the user will need to chose another userName.
            name = userName;

            var collection = Firebase.Firestore.FirebaseFirestore.Instance.Collection("userData");//we download all the userData collection from firesStore.
            //var query = collection.WhereEqualTo("userName", userName);
            await collection.Get().AddOnCompleteListener(this);//we call the method addOnComplete

            if(UserNameOrinalityStatement)//if the userNameOrinalityStatement is false, the user will need to chose anothe UserName
            {
                return true;
            }
            else
            {
                return false;
            }

        }//end userNameOriginality


        public void OnComplete(Android.Gms.Tasks.Task task)
        {
            String userNames = "";
            String nameLower = "";
            String userNamesLower = "";


            try
            {
                if (task.IsSuccessful)
                {
                    var documents = (QuerySnapshot)task.Result;
                    foreach (var doc in documents.Documents)//we go though each user
                    {
                         userNames = doc.Get("userName").ToString();//we save the userName from firestore in the userNames variable

                         nameLower = name.ToLower();//we put in lower case the username that the user put in the app
                         userNamesLower = userNames.ToLower();//we put in lower case the username that we have saved from the firestore

                        if (userNamesLower.Equals(nameLower))//if one username have the same name that the new user wants, the for method will break and stop seraching;
                        {
                            UserNameOrinalityStatement = false;//the we will return false and the if above will return also false.
                            break;
                        }//end if

                    }//end for


                    

                }//end if
            }//end try
            catch(Exception error)
            {
                throw new Exception(error.GetType().ToString());
            }//end cath
            
        }//end OnComplete

        
    }//end class
}//end namespace