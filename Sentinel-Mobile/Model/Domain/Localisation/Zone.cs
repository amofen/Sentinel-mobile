using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    public class Zone
    {
        public String CodeParc { get; set; }
        public String Nom { get; set; }
        public String Code { get; set; }
        public bool Libre { get; set; }
        public int NbrMaxPlateformes { get; set; }
        public List<Plateforme> Plateformes { get; set; }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
