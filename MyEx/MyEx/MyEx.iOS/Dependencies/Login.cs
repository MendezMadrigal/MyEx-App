using Foundation;
using MyEx.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(MyEx.iOS.Dependencies.Login))]
namespace MyEx.iOS.Dependencies
{
    public class Login : ILogin
    {
        public Login()
        {
        }//end 

        
       

        public async Task<bool> LoginUser(string email, string password)
        {

            //We need to test the app in iphone to get the new error names and add it.
            try
            {
               await Firebase.Auth.Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
               return true;
            }
            catch(Exception error)
            {
                throw new Exception(error.GetType().ToString());
            }
           
            
        }//en Login User

       
    }//end class
}//end namespace