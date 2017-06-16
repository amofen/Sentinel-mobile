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


        //La synchronisation des données
        List<DeclarationAnomalie> getDeclarationsByEtatSync(int syncEtat);
        void setDeclarationAnomalieEtatSync(String vin,String codeAnomalie, int syncEtat);
        bool isDeclarationValidee(DeclarationAnomalie dec);
        void setDeclarationAnomalieEtatVal(string vin, int val);
    }
}
