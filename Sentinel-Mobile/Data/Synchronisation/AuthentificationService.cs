using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Data.Config;
using CodeTitans.JSon;
using System.Net;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class AuthentificationService
    {
        public bool authentifierUtilisateur(String nomUtilisateur,String motPasse)
        {
            JSonWriter writer = new JSonWriter();
            writer.WriteObjectBegin();
            writer.WriteMember("UserName", nomUtilisateur);
            writer.WriteMember("Password", motPasse);
            writer.WriteObjectEnd();
            HttpWebResponse reponse =  APIConsumer.postJsonRequest(ConnexionParam.AUTH_SERVICE,writer.ToString());
            if (reponse.StatusCode == HttpStatusCode.OK && reponse.Headers["Set-Cookie"]!=null)
            {
                UtilisateurCache.CurrentUserName = nomUtilisateur;
                UtilisateurCache.CurrentUserCookie = reponse.Headers["Set-Cookie"];
                UtilisateurCache.CurrentUserPassword = motPasse;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
