﻿using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.DTO;

namespace Sentinel_Mobile.Model.Util
{
    class DTOToModelConverter
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
            lot.DatePrevueArrive = DateTime.Parse(lotDTO.DatePrevueArrivage);
            //lot.DateReelleArrive = DateTime.Parse(lotDTO.DateReelleArrive);
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
    }
}
