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

namespace Persia
{
    [Activity(Label = "VentanaSubirFoto")]
    public class VentanaSubirFoto : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.VentanaSubirFoto);

            Window.DecorView.SystemUiVisibility = StatusBarVisibility.Hidden;
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);

            // Create your application here
            this.BotonTomarFoto();

            this.BotonBack();
        }

        private void BotonTomarFoto()
        {
            ImageButton botonSubirFoto = FindViewById<ImageButton>(Resource.Id.BotonSubirFoto);

            botonSubirFoto.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaCrearPublicacion));
                StartActivity(intent);
            };
        }

        private void BotonBack()
        {
            ImageButton botonBack = FindViewById<ImageButton>(Resource.Id.BotonBack);

            botonBack.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaElegirCategoria));
                StartActivity(intent);
            };
        }
    }
}