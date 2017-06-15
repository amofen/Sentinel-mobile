using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Data.Cache.DAO.Application;
using Sentinel_Mobile.Data.Config;

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
            if (authService.authentifierUtilisateur(nomUtilisateur, motPasse))
            {
                //TODO: Ajouter les informations au cahche Nom utilisateur,pass,cookie,typeutil,point,affectation
                ParametreDAO paramDAO = new ParametreDAOImpl();
                paramDAO.setParametre(UtilisateurCache.Params.NOM_UTILISATEUR, UtilisateurCache.CurrentUserName);
                paramDAO.setParametre(UtilisateurCache.Params.MOT_PASSE_UTILISATEUR, UtilisateurCache.CurrentUserPassword);
                paramDAO.setParametre(UtilisateurCache.Params.COOKIE_SESSION, UtilisateurCache.CurrentUserCookie);
                return true;
            }
            else return false;
        }
    }
}
