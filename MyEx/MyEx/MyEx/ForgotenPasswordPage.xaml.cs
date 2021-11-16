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
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }//end Ok_Clicked
    }
}