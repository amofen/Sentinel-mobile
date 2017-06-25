using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Vehicules;
using Sentinel_Mobile.Model.Domain.Infrastructures;
using Sentinel_Mobile.Controlers;
using System.Data;
using Sentinel_Mobile.Data.Config;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class ChoixArrivageController
    {
        private FEN_Choix_Arrivage fen_choix_arrivage;
        private LotManager lotManager;
        private ChargementManager chrManager;

        public ChoixArrivageController(FEN_Choix_Arrivage fen_choix_arrivage)
        {
            this.fen_choix_arrivage = fen_choix_arrivage;
            this.lotManager = new LotManager();
            this.chrManager = new ChargementManager();
        }


        public void initCbxSource()
        {
            List<PointLivrable> listPtsLivrables = chrManager.getListPointLivreableByType(PointLivrable.PORT);
            fen_choix_arrivage.Cbx_Source.Items.Clear();
            fen_choix_arrivage.Cbx_Source.Items.Add("<-- Point Source -->");
            fen_choix_arrivage.Cbx_Source.SelectedIndex = 0;
            if (listPtsLivrables != null)
            {
                foreach (PointLivrable ptLivrable in listPtsLivrables)
                {
                    fen_choix_arrivage.Cbx_Source.Items.Add(ptLivrable);
                    if (ptLivrable.Code == UtilisateurCache.Affectation.Code) fen_choix_arrivage.Cbx_Source.SelectedItem = ptLivrable;
                }
            }
        }


        public void initCbxArrivage()
        {
            fen_choix_arrivage.Cbx_Arrivages.Items.Clear();
            fen_choix_arrivage.Cbx_Arrivages.Items.Add("<-- Arrivage -->");
            fen_choix_arrivage.Cbx_Arrivages.SelectedIndex = 0;
            if (fen_choix_arrivage.Cbx_Source.SelectedIndex != 0)
            {
                PointLivrable ptLivrable = (PointLivrable)fen_choix_arrivage.Cbx_Source.SelectedItem;
                List<Arrivage> listArrivage = lotManager.getArrivageByPtLivrableCode(ptLivrable.Code);
                if (listArrivage != null)
                {
                    foreach (Arrivage arrivage in listArrivage)
                    {
                        fen_choix_arrivage.Cbx_Arrivages.Items.Add(arrivage);
                    }
                }
            }
            updateListLots();
        }

        public void updateListLots()
        {
            fen_choix_arrivage.Lst_Lots.Items.Clear();
            if (fen_choix_arrivage.Cbx_Arrivages.SelectedIndex != 0)
            {
                Arrivage arrivage = (Arrivage)fen_choix_arrivage.Cbx_Arrivages.SelectedItem;
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Numéro", typeof(String)),
                            new DataColumn("Date Prevue", typeof(DateTime)),
                            new DataColumn("Nb Vehicules",typeof(int)) });
                foreach (Lot lot in arrivage.lots)
                {
                    
                    fen_choix_arrivage.Lst_Lots.Items.Add(lot);
                }
            }
        }

        public void choisirLot()
        {
            if (fen_choix_arrivage.Lst_Lots.SelectedItem != null && fen_choix_arrivage.Cbx_Arrivages.SelectedIndex != 0)
            {
                FEN_Check_Arri fen = new FEN_Check_Arri();
                fen.Tag = fen_choix_arrivage;
                Lot lot = (Lot)fen_choix_arrivage.Lst_Lots.SelectedItem;
                Arrivage arrivage = (Arrivage)fen_choix_arrivage.Cbx_Arrivages.SelectedItem;
                CheckArrivageController checkArriController = new CheckArrivageController(fen);
                fen.setCheckArrivageController(checkArriController);
                PointLivrable ptLivrable = (PointLivrable)fen_choix_arrivage.Cbx_Source.SelectedItem;
                checkArriController.initDonneesArrivage(lot, arrivage, ptLivrable);
                fen.Show();
                fen_choix_arrivage.Hide();
                fen_choix_arrivage.pauseCnxTest();
            }
        }
    }
}
