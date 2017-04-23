using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sentinel_Mobile.Presentation.Util
{
    class MessagingService
    {
        public static void showErrorMessage(String msg)
        {
            MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }
    }
}
