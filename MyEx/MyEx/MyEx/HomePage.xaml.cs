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
    public partial class HomePage : MasterDetailPage //para tener un menu desplegable
    {
        public HomePage()
        {
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            App.MasterDet = this;
        }
    }
}