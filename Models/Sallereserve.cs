using System;
using System.Collections.Generic;

namespace test13.Models
{
    public partial class Sallereserve
    {
        public short Id { get; set; }
        public short NumSalle { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public DateTime Date { get; set; }
        public short IdUser { get; set; }
        public short IdAdmin { get; set; }

        public Admin IdAdminNavigation { get; set; }
        public User IdUserNavigation { get; set; }
        public Salle NumSalleNavigation { get; set; }
    }
}
