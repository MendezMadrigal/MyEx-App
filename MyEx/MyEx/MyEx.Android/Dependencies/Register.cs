using Android.App;
using Android.Content;
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


[assembly: Dependency(typeof(MyEx.Droid.Dependencies.Register))]
namespace MyEx.Droid.Dependencies
{
    public class Register : IRegister
    {
        public async Task<bool> RegisterUser(string email, string password, string username, string gender)
        {
            try
            {
                await Firebase.Auth.FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);//here we register the user in the authenticate section of firestore.
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



    }//end class
}//end namespace