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
        public static bool test() 
        {
            using (TcpClient client = new TcpClient())
            {
                try
                {
                    IPAddress ip = IPAddress.Parse(ConnexionParam.SERVER_IP);
                    client.Connect(ip, ConnexionParam.SERVER_PORT);
                    client.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    client.Close();
                    throw new ConnexionNonDisponibleException();
                }
            }
        }

        public class ConnexionNonDisponibleException : Exception
        {
        }
    }
}
