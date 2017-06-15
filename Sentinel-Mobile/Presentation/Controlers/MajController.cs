using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile.Presentation.Controlers
{
    class MajController
    {
        FEM_Mise_A_Jour fen_maj;
        InitController initCtrl;
        public MajController(FEM_Mise_A_Jour fen_maj)
        {
            this.fen_maj = fen_maj;
            this.initCtrl = new InitController();
        }

        public void mettreAJour()
        {
                
                initCtrl.initPtLivrables();
                SplashManager.CloseSplashScreen();
                SplashManager.ShowSplashScreen("Téléchargement arrivages");
                initCtrl.initArrivages();
                SplashManager.CloseSplashScreen();

            
        }
    }
}
