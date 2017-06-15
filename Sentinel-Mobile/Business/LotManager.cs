using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Data.Synchronisation;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Data.Cache.DAO.Vehicules;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Data.Cache.DAO.Transport;
namespace Sentinel_Mobile.Business
{
    class LotManager
    {
        public List<Lot> getLotsPrevu(String idPort)
        {
            List<Lot> lots = new List<Lot>();
            LotService lotService = new LotService();
            foreach (LotDTO lotDTO in lotService.getLotPrevu())
            {
                Lot lot = ModelDTOConverter.convertLot(lotDTO);
                lots.Add(lot);
            }
            return lots;
            
        }

        public void saveLots(List<Lot> lots)
        {
            LotDAO lotDAO = new LotDAOImpl();
            foreach (Lot lot in lots)
            {
                lotDAO.sauvegarderLot(lot);
            }
        }



        public List<Lot> getCacheLots()
        {
            LotDAO lotDAO = new LotDAOImpl();
            return lotDAO.getCacheLots();

        }


        public List<Arrivage> getArrivagePrevue()
        {
            List<Arrivage> listArrivages = new List<Arrivage>();
            LotService lotService = new LotService();
            foreach (ArrivageDTO arrivageDTO in lotService.getArrivagePrevue())
            {
                Arrivage arrivage = new Arrivage();
                arrivage.Code = arrivageDTO.Code;
                arrivage.Date = arrivageDTO.Date;
                ChargementManager chrManager = new ChargementManager();
                arrivage.Source = chrManager.getListPointLivreableById(arrivageDTO.Source); ;
                arrivage.lots = new List<Lot>();
                foreach (LotDTO lotDTO in arrivageDTO.lots)
                {
                    Lot lot = ModelDTOConverter.convertLot(lotDTO);
                    lot.CodeArrivage=arrivage.Code;
                    arrivage.lots.Add(lot);
                }
                listArrivages.Add(arrivage); 
            }
            return listArrivages;
        }

        public void saveArrivages(List<Arrivage> listArrivages)
        {
            LotDAO dao = new LotDAOImpl();
            foreach (Arrivage arrivage in listArrivages)
            {
                dao.sauvegarderArrivage(arrivage);
            }
        }


        public List<Arrivage> getArrivageByPtLivrableCode(String code)
        {
            LotDAO dao = new LotDAOImpl();
            return dao.getArrivageByPtLivrableCode(code);
        }

    }
}
