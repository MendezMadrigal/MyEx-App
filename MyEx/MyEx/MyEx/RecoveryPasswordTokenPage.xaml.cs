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
    public partial class RecoveryPasswordTokenPage : ContentPage
    {
        public RecoveryPasswordTokenPage()
        {
            InitializeComponent();
            var assembly = typeof(RecoveryPasswordTokenPage);
            RecoveryPasswordImage.Source = ImageSource.FromResource("MyEx.Assets.Images.RecoveryPassword.email-verification.png", assembly);
        }

        private void resend_Clicked(object sender, EventArgs e)
        {

        }

        private void confirm_Clicked(object sender, EventArgs e)
        {

        }
    }
}