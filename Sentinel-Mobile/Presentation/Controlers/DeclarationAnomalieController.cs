using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Business;
using Sentinel_Mobile.Model.Domain.Avaries;
using System.Windows.Forms;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class DeclarationAnomalieController
    {
        private FEN_DEC_AVA fen_dec_ava;
        private AnomalieManager anomalieManager;

        public DeclarationAnomalieController(FEN_DEC_AVA fen)
        {
            this.fen_dec_ava = fen;
            this.anomalieManager = new AnomalieManager();
        }

        public void declarerAnomalies()
        {
            Dictionary<String, bool>.Enumerator enumerateur = fen_dec_ava.declarations.GetEnumerator();
            while (enumerateur.MoveNext())
            {
                String currentKey = enumerateur.Current.Key;
                bool currentValue = enumerateur.Current.Value;
                if (fen_dec_ava.declarationsOrig[currentKey] != currentValue)
                {
                    if (currentValue)
                    {
                        anomalieManager.declarerAnomalie(fen_dec_ava.Vin, currentKey,fen_dec_ava.Etape);
                    }
                    else
                    {
                        anomalieManager.retirerDeclaration(fen_dec_ava.Vin, currentKey);
                    }
                }
            }
            if (!fen_dec_ava.declarations.ContainsValue(true)) fen_dec_ava.DialogResult = DialogResult.Yes;
            else fen_dec_ava.DialogResult = DialogResult.No;
            fen_dec_ava.Close();

        }

        public void initialiserAnomalies()
        {
            
            List<DeclarationAnomalie> declarations = anomalieManager.getListAnomaliesByVin(fen_dec_ava.Vin);
            foreach (DeclarationAnomalie declaration in declarations)
            {
                fen_dec_ava.declarationsOrig[declaration.Anomalie] = true;
                fen_dec_ava.CheckBoxes[declaration.Anomalie].Checked = true;
            }
        }

        public void initialiserDictionnaires()
        {
            List<String> codes = anomalieManager.getListCodesAnomalies();
            foreach (String code in codes)
            {
                fen_dec_ava.declarationsOrig[code] = false;
                fen_dec_ava.declarations[code] = false;
            }
        }
    }
}
