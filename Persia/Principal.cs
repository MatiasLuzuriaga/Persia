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
using System.Threading.Tasks;

namespace Persia.Resources.layout
{
    [Activity(Label = "Principal", MainLauncher = true)]
    public class Principal : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Principal);

            Window.DecorView.SystemUiVisibility = StatusBarVisibility.Hidden;
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);

            // Create your application here

            ImageView imagenBase = FindViewById<ImageView>(Resource.Id.imageFondo);

            imagenBase.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(LoginFacebook));
                StartActivity(intent);
            };

        }

     


    }
}