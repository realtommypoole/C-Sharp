using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PingPong.Models
{
    public enum League
    {
        A, B
    }

    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public League? League { get; set; }

        public virtual ICollection<Player> Players { get; set; } //team can have multiple players
    }
}