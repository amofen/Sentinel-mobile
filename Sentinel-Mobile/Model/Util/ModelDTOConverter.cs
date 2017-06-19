using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Localisation;

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

        public static Zone convertZones(ZoneDTO zoneDTO,String codeParc)
        {
            Zone zone = new Zone();
            zone.CodeParc = codeParc;
            zone.Code = zoneDTO.Code;
            zone.Libre = zoneDTO.Libre;
            zone.Nom = zoneDTO.Nom;
            zone.NbrMaxPlateformes = zoneDTO.NbrMaxPlateforme;
            zone.Plateformes = new List<Plateforme>();
            foreach (PlateformeDTO plateformeDTO in zoneDTO.Plateformes)
            {
                Plateforme plateforme = new Plateforme();
                plateforme.CodeZone = zone.Code;
                plateforme.Code = plateformeDTO.Code;
                plateforme.NbrMaxRangees = plateformeDTO.NbrMaxRangees;
                plateforme.Rangees = new List<Range>();
                foreach (RangeeDTO rangeDTO in plateformeDTO.Rangees)
                {
                    Range rangee = new Range();
                    rangee.CodePlateforme = plateforme.Code;
                    rangee.Code = rangeDTO.Code;
                    rangee.CodeZone = zone.Code;
                    rangee.NbrMaxPlaces = rangeDTO.NbrMaxPlaces;
                    plateforme.Rangees.Add(rangee);
                }
                zone.Plateformes.Add(plateforme);
            }
            return zone;
        }
    }
}
