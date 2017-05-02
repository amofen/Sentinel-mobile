using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Data.Cache.DAO.Avaries;

namespace Sentinel_Mobile.Business
{
    class AnomalieManager
    {
        public void declarerAnomalie(String vin, String codeAnomalie,int etape)
        {
            //Création de la déclaration
            DeclarationAnomalie declaration = new DeclarationAnomalie();
            declaration.Vin = vin;
            declaration.Anomalie = codeAnomalie;
            declaration.Date = DateTime.Now;
            declaration.Etape = etape;

            //Sauvegarde de la déclaration
            DeclarationAnomalieDAO dao = new DeclarationAnomalieDAOImpl();
            dao.sauvegarder(declaration);
        }
        public void retirerDeclaration(String vin, String codeAnomalie)
        {
            DeclarationAnomalieDAO dao = new DeclarationAnomalieDAOImpl();
            dao.retirerDeclaration(vin,codeAnomalie);
        }
        public List<DeclarationAnomalie> getListAnomaliesByVin(String vin)
        {
            DeclarationAnomalieDAO dao = new DeclarationAnomalieDAOImpl();
            return dao.getDeclarationsByVin(vin);
        }
        public List<String> getListCodesAnomalies()
        {
            AnomalieDAO dao = new AnomalieDAOImpl();
            return dao.getAnomalies();
        }

        public bool vehiculeAvecAnomalie(string vin)
        {
            DeclarationAnomalieDAO dao = new DeclarationAnomalieDAOImpl();
            return dao.vehiculeAvecAnomalie(vin);
        }
    }
}
