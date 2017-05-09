using System;

using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Sentinel_Mobile.Data.Util
{
    class APIConsumer
    {
        /**
         * Consommer un service web REST sur l'uri URI
         * return JSON sous form de String
         * return null dans le cas d'un problème**/
        public static string getJsonResponse(String URI)
        {
            WebRequest request = null;
            HttpWebResponse response = null;
            try
            {

                request = WebRequest.Create(URI);
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream stream = response.GetResponseStream();
                    StreamReader streamReader = new StreamReader(stream);
                    String json = streamReader.ReadToEnd();
                    streamReader.Close();
                    stream.Close();
                    response.Close();
                    return json;
                }
                else
                {
                    response.Close();
                    return null;
                }

            }
            catch (Exception e)
            {
                Debug.Write(e.StackTrace);
                if (response != null) response.Close();
                return null;
            }
        }
        public static HttpWebResponse postJsonRequest(String URI, String json)
        {
            WebRequest request = null;
            HttpWebResponse response = null;
            try
            {

                request = WebRequest.Create(URI);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = json.Length;
                Stream str = request.GetRequestStream();
                
                StreamWriter writer = new StreamWriter(str);
                writer.Write(json);
                writer.Close();
                response = (HttpWebResponse)request.GetResponse();
                return response;    

            }
            catch (Exception e)
            {
                Debug.Write(e.StackTrace);
                if (response != null) response.Close();
                return null;
            }
        }
    }
}
