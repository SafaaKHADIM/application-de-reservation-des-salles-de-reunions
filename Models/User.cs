using System;
using System.Collections.Generic;

namespace test13.Models
{
    public partial class User
    {
        public User()
        {
            Reservetion = new HashSet<Reservetion>();
            Sallereserve = new HashSet<Sallereserve>();
        }

        public short IdUser { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public short MotDePasse { get; set; }

        public ICollection<Reservetion> Reservetion { get; set; }
        public ICollection<Sallereserve> Sallereserve { get; set; }
    }
}
