using System;

using System.Collections.Generic;
using System.Text;
using Sentinel_Mobile.Model.Domain.Infrastructures;

namespace Sentinel_Mobile.Model.Domain.Vehicules
{
    class Arrivage
    {
        public long Code { get; set; }
        public DateTime Date { get; set; }
        public List<Lot> lots { get; set; }
        public PointLivrable Source { get; set;}

        public override string ToString()
        {
            return Date.ToShortDateString()+" - "+lots.Count+" lots";
        }
    }
}
