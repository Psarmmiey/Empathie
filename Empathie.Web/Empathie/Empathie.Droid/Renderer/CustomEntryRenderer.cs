using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Empathie.Custom;
using Empathie.Droid.Renderer;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]
namespace Empathie.Droid.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = Resources.GetDrawable(Resource.Drawable.BottomBorder);
                Control.SetTextColor(global::Android.Graphics.Color.Black);
            }
        }
    }
}