using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Data.Cache.DAO.Avaries;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;

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

        internal List<Anomalie> getAnomaliesByType(int type)
        {
            AnomalieDAO dao = new AnomalieDAOImpl();
            return dao.getAnomaliesByType(type);
        }

        public List<Anomalie> getListAvaries()
        {
            List<Anomalie> anomalies = new List<Anomalie>();
            AnomalieService anomalieService = new AnomalieService();
            List<AnomalieDTO> anomaliesDTO = anomalieService.getListAvaries();
            foreach (AnomalieDTO anomalieDTO in anomaliesDTO)
            {
                Anomalie anomalie = new Anomalie();
                anomalie.Id = anomalieDTO.Id;
                anomalie.Designation = anomalieDTO.Designation;
                anomalie.Type = Anomalie.AVARIE;
                anomalies.Add(anomalie);
            }
            return anomalies;
        }
        public List<Anomalie> getListObjetsManquants()
        {
            List<Anomalie> anomalies = new List<Anomalie>();
            AnomalieService anomalieService = new AnomalieService();
            List<AnomalieDTO> anomaliesDTO = anomalieService.getListObjetsManquants();
            foreach (AnomalieDTO anomalieDTO in anomaliesDTO)
            {
                Anomalie anomalie = new Anomalie();
                anomalie.Id = anomalieDTO.Id;
                anomalie.Designation = anomalieDTO.Designation;
                anomalie.Type = Anomalie.MANQUE;
                anomalies.Add(anomalie);
            }
            return anomalies;
        }

        public void enregistrerAnomalies(List<Anomalie> anomalies)
        {
            AnomalieDAO dao = new AnomalieDAOImpl();
            foreach (Anomalie anomalie in anomalies)
            {
                try
                {
                    dao.sauvegarderAnomalie(anomalie);
                }
                catch (Exception e)
                {
                    
                }
            }
        }
    }
}
