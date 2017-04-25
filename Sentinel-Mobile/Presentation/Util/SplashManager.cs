using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;  
using System.Windows.Forms;
using Sentinel_Mobile.Presentation.Forms;

namespace Sentinel_Mobile.Presentation.Util
{
    class SplashManager
    {
        static FEN_Splash_Chargement ms_frmSplash = null;
        static public string message = "";
        static Thread th = null;
        // A static method to close the SplashScreen
        static public void CloseSplashScreen()
        {

            if (ms_frmSplash != null)
            {
                ms_frmSplash.Invoke(ms_frmSplash.myDelegate);
                ms_frmSplash.Dispose();
                ms_frmSplash = null;
            }
            else if (th != null)
            {
                th.Abort();
                th = null;
            }

        }
        static public void ShowSplashScreen(string text)
        {
            message = text;
            th = new Thread(new ThreadStart(createForm));
            th.IsBackground = true;
            th.Start();
            
        }

        static private void createForm()
        {
            if (SplashManager.ms_frmSplash == null)
            {
                ms_frmSplash = new FEN_Splash_Chargement(message);
                Application.Run(ms_frmSplash);
            }
        }

        public static bool isOn()
        {
            if (ms_frmSplash == null) return false;
            else return true;
        }




    }
}
