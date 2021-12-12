using System;
using System.Collections.Generic;
using System.Text;
using MyEx; 
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyEx.Helper
{
    public interface ILogin
    {
        Task<bool> LoginUser(string email, string password);
    }//end interface


    public class Login
    {
        public static String error = "";
        private static ILogin Log = DependencyService.Get<ILogin>();

        
        public static async Task<bool> LoginUser(string email, string password)
        {

            try
            {
                return await Log.LoginUser(email, password);
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }


            
        }//end LoginUser

    }//end class
}//end namespace
