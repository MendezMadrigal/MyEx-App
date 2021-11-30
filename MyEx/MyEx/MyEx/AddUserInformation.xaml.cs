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
    public partial class AddUserInformation : ContentPage
    {
        public AddUserInformation()
        {
            InitializeComponent();


            Gender.Items.Add("Hombre");
            Gender.Items.Add("Mujer");
            Gender.Items.Add("Otro");
            maxDate();
        }//end constructor

        private void maxDate()
        {
            DateTime today = DateTime.Now;
            today = today.AddYears(-18);
            BirthDay.MaximumDate = today;
        }//end maxDate

        private void next_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddSpecificUserInformation());
        }
    }//end class
}//end namespace