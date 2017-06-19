using System;

using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Data.Synchronisation;

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
                request.Headers.Add("Cookie", UtilisateurCache.CurrentUserCookie);
                using (response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream stream = response.GetResponseStream())
                        {
                            using (StreamReader streamReader = new StreamReader(stream))
                            {
                                String json = streamReader.ReadToEnd();
                                return json;
                            }
                        }
                    }
                    else
                    {
                        
                        return null;
                    }
                }
            }

            catch (Exception e)
            {
                throw new UnauthorizedException();
                Debug.Write(e.StackTrace);
                if (response != null) response.Close();
                return null;
            }
        }
        public static HttpWebResponse postJsonRequest(String URI, String json)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(URI);
                request.Method = "POST";
                request.ContentType = "application/json";
               
                using (Stream str = request.GetRequestStream())
                {
                    using (StreamWriter writer = new StreamWriter(str))
                    {
                        writer.Write(json);
                    }
                }
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

        public static HttpWebResponse putJsonRequest(String URI, String json)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                request =(HttpWebRequest) WebRequest.Create(URI);
                request.Method = "PUT";
                request.ContentType = "application/json";
                request.ContentLength =Encoding.UTF8.GetBytes(json).Length;
                using (Stream str = request.GetRequestStream())
                {
                    using (StreamWriter writer = new StreamWriter(str))
                    {
                        writer.Write(json);
                    }
                    response = (HttpWebResponse)request.GetResponse();
                }
                
                return response;

            }
            catch (Exception e)
            {
                Debug.Write(e.StackTrace);
                if (response != null) response.Close();
                return null;
            }
        }



        public static HttpWebResponse postAuthJsonRequest(String URI, String json)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(URI);
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] postBytes = Encoding.UTF8.GetBytes(json);
                request.ContentLength = postBytes.Length;
                Stream str = request.GetRequestStream();
                str.Write(postBytes, 0, postBytes.Length);
                str.Close();
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

        internal static HttpWebResponse postJsonRequestAsynch(string URI, string json)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(URI);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                byte[] postBytes = Encoding.UTF8.GetBytes(json);
                request.ContentLength = Encoding.UTF8.GetBytes(json).Length;

                using (Stream str = request.GetRequestStream())
                {
                    str.Write(postBytes, 0, postBytes.Length);
                }
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
