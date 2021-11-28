using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using MyEx.iOS;
using Xamarin.Forms.Platform.iOS;


[assembly:ExportRenderer(typeof(MyEx.CustomLabel),typeof(CustomLabelRender))]
namespace MyEx.iOS
{
    class CustomLabelRender:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                Control.TextAlignment = UITextAlignment.Justified;
            }
        }//end OnElementChanged



    }//end Class
}//end namespace