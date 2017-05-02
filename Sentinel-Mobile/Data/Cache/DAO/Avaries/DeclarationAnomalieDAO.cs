using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Data.Cache.DAO.Avaries
{
    interface DeclarationAnomalieDAO
    {
        int sauvegarder(DeclarationAnomalie declaration);
        List<DeclarationAnomalie> getDeclarationsByVin(String vin);
        void retirerDeclaration(string vin, string codeAnomalie);
        bool vehiculeAvecAnomalie(String vin);
    }
}
