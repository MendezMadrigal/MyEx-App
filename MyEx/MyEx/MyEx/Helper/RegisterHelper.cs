using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyEx.Helper
{
    public interface IRegister
    {
        Task<bool> RegisterUser(String email, String password, String username, String gender);
    }


    public class Register
    {
        public static String error = "";
        private static IRegister register = DependencyService.Get<IRegister>();

        public static async Task<bool> RegisterUser(String email, String password, String username, String gender)
        {
            try
            {
                return await register.RegisterUser(email, password, username, gender);
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }//end RegisterUser

    }//end class

}//end namespace