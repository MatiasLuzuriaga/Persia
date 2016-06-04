using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Persia
{
    [Activity(Label = "Persia")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);
        
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Window.DecorView.SystemUiVisibility = StatusBarVisibility.Hidden;
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);

            // Our code will go here
            Button botonPublicarNuevo = FindViewById<Button>(Resource.Id.BotonPublicarNuevo);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(VentanaElegirCategoria));
                StartActivity(intent);
            };
        }
    }
}

