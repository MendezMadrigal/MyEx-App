using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using MyEx.Droid;
using Xamarin.Forms;
using Android.Text;
using Xamarin.Forms.Platform.Android;


[assembly:ExportRenderer(typeof(MyEx.CustomLabel),typeof(CustomLabelRender))]
namespace MyEx.Droid
{
    public class CustomLabelRender:LabelRenderer
    {

        public CustomLabelRender(Context context): base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                Control.JustificationMode = JustificationMode.InterWord;
            }//end if
        }//end OnElementChanged

    }//end class
}//end namespace