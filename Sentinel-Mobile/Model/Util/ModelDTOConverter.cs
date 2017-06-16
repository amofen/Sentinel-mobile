using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Business;

namespace Sentinel_Mobile.Model.Util
{
    class ModelDTOConverter
    {
        public static Vehicule convertVehicule(VehiculeDTO vehiculeDTO)
        {
            Vehicule vehicule = new Vehicule();
            vehicule.Vin = vehiculeDTO.Vin;
            vehicule.Model = vehiculeDTO.Marque+" "+vehiculeDTO.Modele;
            vehicule.Couleur = vehiculeDTO.Couleur;
            vehicule.Lot = null;
            return vehicule;
        }

        public static Lot convertLot(LotDTO lotDTO) {
            Lot lot = new Lot();
            lot.Id = lotDTO.Numero+"";
            lot.vehicules = new List<Vehicule>();
            foreach (VehiculeDTO vehiculeDTO in lotDTO.Vehicules)
            {
                Vehicule vehicule = convertVehicule(vehiculeDTO);
                vehicule.Lot = lot.Id;
                lot.vehicules.Add(vehicule);                
            }
            return lot;
        }

        public static List<Lot> convertLot(List<LotDTO> lotDTOList)
        {
            List<Lot> lots = new List<Lot>();
            foreach (LotDTO lotDTO in lotDTOList)
            {
                lots.Add(convertLot(lotDTO));
            }
            return lots;
        }

        public static ScanDTO convertScan(Scan scan)
        {
            ScanDTO scanDTO = new ScanDTO();
            scanDTO.Vin = scan.Vin;
            scanDTO.Date = scan.Date;
            scanDTO.Etape = scan.Etape;
            scanDTO.CodePtLivrable = scan.CodePtLivrable;
            return scanDTO;
        }

        public static DeclarationAnomalieDTO convertDevlarationAnomalie(DeclarationAnomalie declaration)
        {
            DeclarationAnomalieDTO declarationDTO = new DeclarationAnomalieDTO();
            declarationDTO.Vin=declaration.Vin;
            declarationDTO.Anomalie=declaration.Anomalie;
            declarationDTO.Date=declaration.Date;
            declarationDTO.Etape=declaration.Etape;
            declarationDTO.Type = (new AnomalieManager()).getTypeAnomalieByCode(declaration.Anomalie);
            return declarationDTO;
        }
    }
}
