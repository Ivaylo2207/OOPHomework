using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHomework
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public List<AssistantReferee> AssistantReferees { get; set; }
        public Referee Referee { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }
    }
}
