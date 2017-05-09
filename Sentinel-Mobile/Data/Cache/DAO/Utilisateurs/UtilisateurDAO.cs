using System;
using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model;
using Sentinel_Mobile.Model.Domain.Utilisateur;

namespace Sentinel_Mobile.Data.Cache.DAO.Utilisateurs
{
    interface UtilisateurDAO
    {
         Utilisateur getUtilisateur();
         void sauvgarderUtilisateur();
    }
}
