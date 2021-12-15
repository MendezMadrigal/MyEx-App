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
        Task<bool> userNameOriginality(string userName);
    }//end IRegister


    public class Register
    {
        public static String error = "";
        private static IRegister register = DependencyService.Get<IRegister>();

        public static async Task<bool> RegisterUser(String email, String password, String userName, String gender)
        {

            bool userNameApproval = await userNameOriginality(userName); //We make sure the user name is original and unique.

            if (userNameApproval)//if the userName is new, the user will be able to make a new account
            {
                try
                {
                    return await register.RegisterUser(email, password, userName, gender);//we call the RegisterUser method depending in which OS is using.
                }//end try
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }///end cath
            }//end if
            else
            {
                error = "El nombre de usuario ya está registrado, intente con uno diferente.";
                return false;
            }//end else

            
        }//end RegisterUser




        private static async Task<bool> userNameOriginality(string userName)//with this function we see if the username is original.
        {
            return await register.userNameOriginality(userName);
        }//end userNameOriginality






    }//end class

}//end namespace