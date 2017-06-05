using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Model.Domain.Localisation
{
    class Zone
    {
        public String CodePointLivrable { get; set; }
        public String Nom { get; set; }
        public bool Libre { get; set; }
        public int NbMaxPlateformes { get; set; }
        public List<Plateforme> Plateformes { get; set; }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
