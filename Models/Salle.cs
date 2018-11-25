using System;
using System.Collections.Generic;

namespace test13.Models
{
    public partial class Salle
    {
        public Salle()
        {
            Reservetion = new HashSet<Reservetion>();
            Sallereserve = new HashSet<Sallereserve>();
        }

        public short NumSalle { get; set; }
        public short Etage { get; set; }
        public short NbrDePlace { get; set; }
        public byte Datashow { get; set; }

        public ICollection<Reservetion> Reservetion { get; set; }
        public ICollection<Sallereserve> Sallereserve { get; set; }
    }
}
