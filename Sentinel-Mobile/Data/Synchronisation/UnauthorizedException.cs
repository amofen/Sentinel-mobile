using System;

using System.Collections.Generic;
using System.Text;

namespace Sentinel_Mobile.Data.Synchronisation
{
    class UnauthorizedException:Exception
    {
        public String customMessage;
        public UnauthorizedException()
        {
            this.customMessage = "Non autorisé";
        }
    }
}
