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
    [Activity(Label = "VentanaElegirCategoria")]
    public class VentanaElegirCategoria : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.VentanaElegirCategoria);

            Window.DecorView.SystemUiVisibility = StatusBarVisibility.Hidden;
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);

            this.BotonBack();
            this.SeleccionoCategoriaElectronica();
            this.SeleccionoCategoriaMuebles();
            this.SeleccionoCategoriaLibros();
            this.SeleccionoCategoriaPeliculas();
            this.SeleccionoCategoriaMusica();
            this.SeleccionoCategoriaDeco();
            this.SeleccionoCategoriaRopa();
            this.SeleccionoCategoriaJuegos();
            this.SeleccionoCategoriaOtros();
            // Create your application here
        }

        private void BotonBack()
        {
            ImageButton botonBack = FindViewById<ImageButton>(Resource.Id.BotonBack);

            botonBack.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaElectronica()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaElectronica);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaMuebles()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaMuebles);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaLibros()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaLibros);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaPeliculas()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaPeliculas);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaMusica()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaMusica);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaDeco()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaDeco);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaRopa()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaRopa);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaJuegos()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaJuegos);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

        private void SeleccionoCategoriaOtros()
        {
            ImageButton botonPublicarNuevo = FindViewById<ImageButton>(Resource.Id.BotonCategoriaOtros);

            botonPublicarNuevo.Click += (object sender, EventArgs e) =>
            {
                //Aca tengo que Guardar la categoria seleccionada

                //Paso a la nueva ventana
                var intent = new Intent(this, typeof(VentanaSubirFoto));
                StartActivity(intent);
            };
        }

    }
}