using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Persia
{
    public static class Http
    {
        public static String Post(string uri, NameValueCollection pairs)
        {
            byte[] response = null;
            using (WebClient client = new WebClient())
            {
                response = client.UploadValues(uri, pairs);
            }
            return Encoding.Default.GetString(response);
        }
    }

    public class JsonBuilder
    {
        public JsonBuilder()
        {
            using (var wb = new WebClient())

            {
                string apiMethod = "obtenerListaUsuario";
                string apiUrl = "http://muteware.com/persia/api_server.php";

                string response = Http.Post(apiUrl, new NameValueCollection()
            {
                { "api_method", apiMethod                                    },
                { "api_data",   JsonConvert.SerializeObject("") }
            });

                List<UsuarioJson> r =
                    JsonConvert.DeserializeObject<List<UsuarioJson>>(response);
            }
        }
    }
}
