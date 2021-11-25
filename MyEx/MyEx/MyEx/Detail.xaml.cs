using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace MyEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : TabbedPage
    {
        public Detail()
        {
            InitializeComponent();


        }

        private void Add_Appearing(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }//end

        private void Users_Appearing(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);
        }//end

        private void Principal_Appearing(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}