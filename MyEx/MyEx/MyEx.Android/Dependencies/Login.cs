using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyEx.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase.Auth;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(MyEx.Droid.Dependencies.Login))]
namespace MyEx.Droid.Dependencies
{
    public class Login : ILogin
    {
        

        public async Task<bool> LoginUser(string email, string password)
        {
            try
            {
                await Firebase.Auth.FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                return true;
            }
            catch(FirebaseAuthEmailException error)
            {
                throw new Exception("hoa");
            }
            catch (Firebase.Auth.FirebaseAuthInvalidCredentialsException error)
            {
                throw new Exception("Correo electrónico o contraseña incorrectos.");
            }
            catch (Java.Lang.IllegalArgumentException error)
            {
                throw new Exception("Ingrese sus datos de registro.");
            }
            catch (FirebaseAuthException error)
            {
                throw new Exception(error.GetType().ToString());
            }
        }//end LoginUser

        
    }//end class
}//end names space