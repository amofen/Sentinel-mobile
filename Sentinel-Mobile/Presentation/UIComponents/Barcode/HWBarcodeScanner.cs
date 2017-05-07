using System;

using System.Collections.Generic;
using System.Text;
using Honeywell.DataCollection.WinCE.Decoding;
using Honeywell.DataCollection.Decoding;

namespace Sentinel_Mobile.Presentation.UIComponents.Barcode
{
    class HWBarcodeScanner : BarcodeScanner
    {
        private DecodeControl decodeBase;
        #region BarcodeScanner Members

        public void initialise()
        {
            decodeBase = new DecodeControl();


            decodeBase.AimerTimeout = 0;
            decodeBase.AimIDDisplay = true;
            decodeBase.AudioMode = Honeywell.DataCollection.Decoding.AudioDevice.SND_STANDARD;
            decodeBase.AutoLEDs = true;
            decodeBase.AutoScan = true;
            decodeBase.AutoSounds = true;
            decodeBase.CodeIDDisplay = false;
            decodeBase.ContinuousScan = false;
            decodeBase.DecodeAttemptLimit = 800;
            decodeBase.DecodeMode = Honeywell.DataCollection.Decoding.DecodeMode.DM_STANDARD;
            decodeBase.LightsMode = Honeywell.DataCollection.Decoding.ScanLightsMode.LM_ILLUM_AIMER;
            decodeBase.LinearRange = 3;
            decodeBase.Location = new System.Drawing.Point(61, 53);
            decodeBase.ModifierDisplay = false;
            decodeBase.Multiline = true;
            decodeBase.Name = "decodeBase";
            decodeBase.PrintWeight = 4;
            decodeBase.ScanTimeout = 5000;
            decodeBase.SearchTimeLimit = 400;
            decodeBase.Size = new System.Drawing.Size(100, 20);
            decodeBase.TabIndex = 9;
            decodeBase.TabStop = false;
            decodeBase.TraceMode = false;
            decodeBase.TriggerKey = Honeywell.DataCollection.WinCE.Decoding.TriggerKeyEnum.TK_ONSCAN;
            decodeBase.VideoReverse = false;
            decodeBase.VirtualKeyMode = false;
            decodeBase.VirtualKeyTerm = Honeywell.DataCollection.Decoding.VirtualKeyTermEnum.VK_NONE;
            decodeBase.Visible = false;            
        }

        public void activate()
        {
            decodeBase.Connect();
        }

        public void disactivate()
        {
            decodeBase.Enabled = false;
            decodeBase.TriggerKey = TriggerKeyEnum.TK_NONE;
            decodeBase.Disconnect();
            decodeBase.Dispose();
            decodeBase = null;
        }




        public void setScanEventHandler(handleDecodeEvent handler)
        {
            DecodeBase.DecodeEventHandler decDelegate = new DecodeBase.DecodeEventHandler(handler);
            decodeBase.DecodeEvent += decDelegate;
        }

        public string getScannResult(EventArgs e)
        {
            DecodeBase.DecodeEventArgs decEventArgs = (DecodeBase.DecodeEventArgs)e;
            if (!decEventArgs.DecodeResults.pchMessage.Equals("")) return decEventArgs.DecodeResults.pchMessage;
            else return null;
        }

        #endregion
    }
}
