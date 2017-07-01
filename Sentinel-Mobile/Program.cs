using System;

using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using Sentinel_Mobile.Presentation;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Presentation.Controlers;
using Sentinel_Mobile.Presentation.Util;

namespace Sentinel_Mobile
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            try
            {
                InitController ctrl = new InitController();
                ctrl.initConnexion();
                ctrl.initConnectionTestThreads();
                ctrl.initSynchroThreads();
                FEN_Connexion fen_cnx = new FEN_Connexion();
                if (fen_cnx.ShowDialog() == DialogResult.Yes)
                {
                    Application.Run(new FEN_Principale());
                }
                else
                {
                    MessagingService.showErrorMessage("Impossible de s'authentifier !");
                }
            }
            catch (Exception e)
            {
                MessagingService.showErrorMessage(e.Message);
                Application.Exit();
            }
        }
    }
}