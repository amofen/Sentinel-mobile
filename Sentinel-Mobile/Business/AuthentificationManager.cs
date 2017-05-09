using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Synchronisation;

namespace Sentinel_Mobile.Business
{
    class AuthentificationManager
    {
        AuthentificationService authService = null;
        public AuthentificationManager()
        {
            authService = new AuthentificationService();
        }
        public bool authentifierUtilisateur(String nomUtilisateur,String motPasse)
        {
            return authService.authentifierUtilisateur(nomUtilisateur,motPasse);
        }
    }
}
