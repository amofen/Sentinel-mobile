using System;

using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Sentinel_Mobile.Data.Config
{
    public class TrustAllCertificatePolicy : ICertificatePolicy
    {
        public TrustAllCertificatePolicy()
        {
        }

        public bool CheckValidationResult(ServicePoint sp,
            X509Certificate cert, WebRequest req, int problem)
        {
            return true;
        }
    }
}
