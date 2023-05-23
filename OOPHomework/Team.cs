using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHomework
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public double AverageAge;
    }
}
