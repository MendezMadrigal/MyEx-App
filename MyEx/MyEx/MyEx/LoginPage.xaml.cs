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
        public LoginPage()
        {
            
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }//end LoginButton

        private void ForgetPassword_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotenPasswordPage());
        }// end ForgetPassword_Clicked

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }//end SignUp_Clicked
    }
}