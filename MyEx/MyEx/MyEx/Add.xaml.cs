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
    public partial class Add : ContentPage
    {
        public Add()
        {
            InitializeComponent();

            var assembly = typeof(Add);
            addImage.Source = ImageSource.FromResource("MyEx.Assets.Images.Add.alzarLaVozADD.png", assembly);
            
        }//end constructor

        private void AcceptButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUserInformation());
        }//end AcceptButton_Clicked

    }//end class
}