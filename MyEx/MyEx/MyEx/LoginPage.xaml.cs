using MyEx.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {


        /// 
        /// CONSTRUCTOR
        /// 
        public LoginPage()
        {
            
            InitializeComponent();
        }//end constructor



        /// 
        /// 
        /// LOGIN
        /// 
        ///

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {

            bool result = await Login.LoginUser(EmailEntry.Text, PasswordEntry.Text);

            if (result)
            {
                await Navigation.PushAsync(new HomePage());
            }//end if
            else
            {
                ErrorMessage.Text = Login.error;
            }//end else
            
        }//end LoginButton











        ////////  NAVIGATION ACTIONS //////
        private void ForgetPassword_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotenPasswordPage());
        }// end ForgetPassword_Clicked

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }//end SignUp_Clicked


    }//end class
}//end NameSpace