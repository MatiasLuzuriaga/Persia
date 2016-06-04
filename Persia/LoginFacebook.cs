using System;
using Android.App;
using Android.OS;
using Android.Views;
using Xamarin.Auth;
using Newtonsoft.Json.Linq;
using Android.Widget;
using Android.Content;

namespace Persia
{
    [Activity(Label = "LoginFacebook")]
    public class LoginFacebook : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LoginFacebook);

            Window.DecorView.SystemUiVisibility = StatusBarVisibility.Hidden;
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);
            // Create your application here

            ImageView imagenBase = FindViewById<ImageView>(Resource.Id.imageFondo);

            imagenBase.Click += (object sender, EventArgs e) =>
            {
                var auth = new OAuth2Authenticator(clientId: "238926816158937", scope: "", authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"), redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));
                auth.Completed += LoginComplete;
                StartActivity(auth.GetUI(this));
            };
         

        }

        public async void LoginComplete(object sender, AuthenticatorCompletedEventArgs e)
        {
            if (!e.IsAuthenticated)
            {
                mostrarAlerta("Fallo conexion!");
                return;
            }

            var accessToken = e.Account.Properties["access_token"].ToString();
            var expiresIn = Convert.ToDouble(e.Account.Properties["expires_in"]);
            var expiryDate = DateTime.Now + TimeSpan.FromSeconds(expiresIn);

            // Now that we're logged in, make a OAuth2 request to get the user's id.
            var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, e.Account);
            var response = await request.GetResponseAsync();
            var obj = JObject.Parse(response.GetResponseText());
            var id = obj["id"].ToString().Replace("\"", ""); // Id has extraneous quotation marks

            var intent = new Intent(this, typeof(VentanaElegirCategoria));
            StartActivity(intent);
        }

        public void mostrarAlerta(String texto)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);

            alert.SetTitle(texto);

            alert.SetPositiveButton("OK", (senderAlert, args) => {
                //change value write your own set of instructions
                //you can also create an event for the same in xamarin
                //instead of writing things here
            });
            RunOnUiThread(() => {
                alert.Show();
            });
        }



    }
}