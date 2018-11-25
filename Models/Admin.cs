using System;
using System.Collections.Generic;

namespace test13.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Sallereserve = new HashSet<Sallereserve>();
        }

        public short IdAdmin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public short MotDePasse { get; set; }

        public ICollection<Sallereserve> Sallereserve { get; set; }
    }
}
