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
    public partial class Users : ContentPage
    {
        public Users()
        {
            InitializeComponent();
            var assembly = typeof(Users);
            searchImage.Source = ImageSource.FromResource("MyEx.Assets.Images.Search.littleGirl.png");
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchUser());
        }//end next_Clicked




    }//end class
}