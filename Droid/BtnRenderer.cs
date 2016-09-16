using System;
using CustomRenderer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof (Button), typeof (BtnRenderer))]
namespace CustomRenderer.Droid
{
    public class BtnRenderer : ButtonRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged (e);
            var btn = this.Control as Android.Widget.Button;
            btn.SetBackgroundColor (global::Android.Graphics.Color.Green);
        }
    }
}
