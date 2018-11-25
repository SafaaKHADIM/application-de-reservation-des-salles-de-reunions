using System;
using System.Collections.Generic;

namespace test13.Models
{
    public partial class Reservetion
    {
        public short IdRes { get; set; }
        public short NumSalle { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public DateTime Date { get; set; }
        public short IdUser { get; set; }

        public User IdUserNavigation { get; set; }
        public Salle NumSalleNavigation { get; set; }
    }
}
