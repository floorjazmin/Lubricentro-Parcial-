using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Servicios.Rest
{
    class ConsumirServicios
    {
        public string URL { get; set; }
        public string Data { get; set; }

        public ConsumirServicios(string url, string data = "")
        {
            URL = url;
            Data = data;
        }

        public string CreateObject()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);

            try
            {
                var json = "";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }

                return json.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}