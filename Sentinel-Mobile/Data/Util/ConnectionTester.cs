using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Config;
using System.Net.Sockets;
using System.Net;

namespace Sentinel_Mobile.Data.Util
{
    class ConnectionTester
    {
        public static bool IS_CONNECTED =false;

        public static void test() 
        {
            using (TcpClient client = new TcpClient())
            {
                try
                {
                    IPAddress ip = IPAddress.Parse(ConnexionParam.SERVER_IP);
                    client.Connect(ip, ConnexionParam.SERVER_PORT);
                    client.Close();
                    IS_CONNECTED = true;
                }
                catch (Exception ex)
                {
                    client.Close();
                    //TODO: Pour la démo
                    //throw new ConnexionNonDisponibleException();
                    IS_CONNECTED = false;
                }
            }
        }

        public class ConnexionNonDisponibleException : Exception
        {
        }
    }
}
