using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("IndieFlower.ttf")]

namespace MyEx
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new LoginPage());//HERE WE CREATE THAT THE FIRST PAGE WILL BE THE MAINPAGE, AND THE THAT WILL BE ABLE TO DISPLAY ANOTHER PAGES.
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
