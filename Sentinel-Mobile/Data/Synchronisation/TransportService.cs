using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Transport;
using CodeTitans.JSon;
using Sentinel_Mobile.Model.DTO;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class TransportService
    {
        public List<Chauffeur> getChauffeurs()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.CHAUFFEURS_SERVICE);
            List<Chauffeur> listChauffeurs = new List<Chauffeur>();
            if (json!=null)
            {
                JSonReader jReader = new JSonReader();
                IJSonObject jObject = jReader.ReadAsJSonObject(json);
                foreach (IJSonObject chaufJObject in jObject.ArrayItems)
                {
                    ChauffeurDTO dto = new ChauffeurDTO();
                    dto.Read(chaufJObject);
                    Chauffeur chauffeur = new Chauffeur();
                    chauffeur.CodeTransporteur = dto.CodeTransporteur;
                    chauffeur.NomPrenom = dto.NomPrenom;
                    chauffeur.NumeroPermis = dto.NumeroPermis;
                    listChauffeurs.Add(chauffeur);
                } 
            }
            return listChauffeurs;
        }

        public List<Camion> getCmions()
        {
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.CAMIONS_SERVICE);
            List<Camion> listCamions = new List<Camion>();
            if (json!=null)
            {
                JSonReader jReader = new JSonReader();
                IJSonObject jObject = jReader.ReadAsJSonObject(json);
                foreach (IJSonObject camionJObject in jObject.ArrayItems)
                {
                    CamionDTO dto = new CamionDTO();
                    dto.Read(camionJObject);
                    Camion camion = new Camion();
                    camion.NumeroImmatriculation = dto.Id;
                    camion.Transporteur = dto.Transporteur;
                    camion.Modele = dto.Modele;

                    listCamions.Add(camion);
                } 
            }
            return listCamions;
        }

        public List<OpTransportReceptionneeDTO> getOperationsReceptionnee(String codeDestinaton)
        {
            List<OpTransportReceptionneeDTO> listOpRecep = new List<OpTransportReceptionneeDTO>() ;
            String json = APIConsumer.getJsonResponse(Config.ConnexionParam.OPERATION_RECEP_GET_SERVICE+codeDestinaton);
            if (json!=null)
            {
                JSonReader reader = new JSonReader();
                IJSonObject jObject = reader.ReadAsJSonObject(json);
                foreach (IJSonObject opObject in jObject.ArrayItems)
                {
                    OpTransportReceptionneeDTO op = new OpTransportReceptionneeDTO();
                    op.Read(opObject);
                    listOpRecep.Add(op);
                } 
            }
            return listOpRecep;
        }
    }
}
