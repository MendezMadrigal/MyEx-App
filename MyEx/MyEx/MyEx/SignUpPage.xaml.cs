using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEx.Helper;
using Xamarin.Forms;
using MyEx.Helper;
using Xamarin.Forms.Xaml;

namespace MyEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void femaleGenderCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            maleGenderCheckBox.IsChecked = false;
            otherGenderCheckBox.IsChecked = false;
            femaleGenderCheckBox.IsChecked = true;
        }

        private void maleGenderCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            femaleGenderCheckBox.IsChecked = false;
            otherGenderCheckBox.IsChecked = false;
            maleGenderCheckBox.IsChecked = true;
        }

        private void otherGenderCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            femaleGenderCheckBox.IsChecked = false;
            maleGenderCheckBox.IsChecked = false;
            otherGenderCheckBox.IsChecked = true;
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            String gender = "";

            if (String.Equals(email.Text, retypeEmail.Text) && String.Equals(password.Text, ReTypePassword.Text)  && userName.Text != null && (femaleGenderCheckBox.IsChecked || maleGenderCheckBox.IsChecked || otherGenderCheckBox.IsChecked))
            {

                if(femaleGenderCheckBox.IsChecked)
                {
                    gender = "Mujer";
                }
                else if(maleGenderCheckBox.IsChecked)
                {
                    gender = "Hombre";
                }    
                else
                {
                    gender = "Otro";
                }

                bool result = await Register.RegisterUser(email.Text, password.Text, userName.Text, gender);

                if (result)
                {
                    App.Current.MainPage.DisplayAlert("Felicidades", "Ahora en adelante, podrá ingresar a su cuenta mediante su correo electrónico y su contraseña", "OK");
                    await Navigation.PushAsync(new HomePage());
                }//end if
                else
                {
                    errorMessage.Text = Register.error;
                }//end else

            }//end if
            else if (Equals(userName.Text, null))
            {
                errorMessage.Text = "Por favor indique un nombre de usuario.";
            }//end else
            else if (!Equals(email.Text, retypeEmail.Text)) 
            {
                errorMessage.Text = "Los correos electrónicos no coinciden.";
            }//end else
            else if (!Equals(password.Text, ReTypePassword.Text)) 
            {
                errorMessage.Text = "Las contraseñas no coinciden.";
            }//end else
            else if (!femaleGenderCheckBox.IsChecked && !maleGenderCheckBox.IsChecked && !otherGenderCheckBox.IsChecked)
            {
                errorMessage.Text = "Por favor indique el género con el que se identifíca.";
            }//end else
            else
            {
                errorMessage.Text = "Error desconocido, por favor, intente de nuevo en un rato.";
            }



        }//end Register_Clicked

        
    }//end class
}//end nameSpace