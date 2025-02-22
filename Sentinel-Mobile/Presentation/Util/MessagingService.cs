﻿using System;

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

        public static DialogResult confirmation(String msg)
        {
            return MessageBox.Show(msg, "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        internal static void showInfoMessage(string p)
        {
            MessageBox.Show(p, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
    }
}
