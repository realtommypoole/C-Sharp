using PingPong.Data_Access_Layer;
using PingPong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PingPong.ViewModels
{
    public class PlayerDetailViewModel
    {
        public Player Player { get; set; }
        public Team Team { get; set; }
        private TournamentContext _db = new TournamentContext();

        public PlayerDetailViewModel(int PlayerId) 
        {
            Player = _db.Players.Find(PlayerId);
            Team = _db.Teams.Find(Player.TeamID);
        }

    }
}