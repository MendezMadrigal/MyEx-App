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
    public partial class ForgotenPasswordPage : ContentPage
    {
        public ForgotenPasswordPage()
        {
            InitializeComponent();

            var assembly = typeof(ForgotenPasswordPage);
            forgotPasswordImage.Source = ImageSource.FromResource("MyEx.Assets.Images.ForgotetnPassword.forgot-password.png", assembly);
        }//end constructor

        

        private void submit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecoveryPasswordTokenPage());
        }
    }//end class
}