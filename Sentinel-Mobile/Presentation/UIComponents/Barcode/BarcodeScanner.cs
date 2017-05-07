using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Presentation.UIComponents.Barcode
{
    delegate void handleDecodeEvent(object sender, EventArgs e);
    interface BarcodeScanner
    {
        void initialise();
        void activate();
        void disactivate();
        void setScanEventHandler(handleDecodeEvent handler);
        String getScannResult(EventArgs e);
    }
}
