using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PingPong.Models;
using PingPong.Data_Access_Layer;
using System.Data.SqlClient;

namespace PingPong.Data_Access_Layer
{
    public class TournamentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TournamentContext>
    {
        protected override void Seed(TournamentContext context)
        {
            var players = new List<Player>
            {
            new Player{TeamID=1, FirstName="Carson",LastName="Alexander",RightHand=true,DateOfBirth=DateTime.Parse("2005-09-01")},
            new Player{TeamID=1,FirstName="Meredith",LastName="Alonso",RightHand=true,DateOfBirth=DateTime.Parse("2002-09-01")},
            new Player{FirstName="Arturo",LastName="Anand",RightHand=false,DateOfBirth=DateTime.Parse("2003-09-01")},
            new Player{FirstName="Gytis",LastName="Barzdukas",RightHand=true,DateOfBirth=DateTime.Parse("2002-09-01")},
            new Player{TeamID=2,FirstName="Yan",LastName="Li",RightHand=true,DateOfBirth=DateTime.Parse("2002-09-01")},
            new Player{TeamID=2,FirstName="Peggy",LastName="Justice",RightHand=true,DateOfBirth=DateTime.Parse("2001-09-01")},
            new Player{FirstName="Laura",LastName="Norman",RightHand=true,DateOfBirth=DateTime.Parse("2003-09-01")},
            new Player{FirstName="Nino",LastName="Olivetto",RightHand=false,DateOfBirth=DateTime.Parse("2005-09-01")}
            };

            players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();
            
            //var matches = new List<Match>
            //{
            //new Match{MatchID=1050,DateOfMatch=DateTime.Parse("2020-08-01")},
            //new Match{MatchID=4022,DateOfMatch=DateTime.Parse("2020-08-02")},
            //new Match{MatchID=4041,DateOfMatch=DateTime.Parse("2020-08-02")},
            //new Match{MatchID=1045,DateOfMatch=DateTime.Parse("2020-08-01")},
            //new Match{MatchID=3141,DateOfMatch=DateTime.Parse("2020-08-04")},
            //new Match{MatchID=2021,DateOfMatch=DateTime.Parse("2020-08-04")},
            //new Match{MatchID=2042,DateOfMatch=DateTime.Parse("2020-08-06")}
            //};
            //matches.ForEach(s => context.Matches.Add(s));
            //context.SaveChanges();
            
            var teams = new List<Team>
            {
            new Team{TeamID=1,TeamName="Fireful",League=League.A},
            new Team{TeamID=2,TeamName="Fighters",League=League.A},
            new Team{TeamID=3,TeamName="Bouncers",League=League.B},
            new Team{TeamID=4,TeamName="Biggies",League=League.B}
            };
            teams.ForEach(s => context.Teams.Add(s));
            context.SaveChanges();
        }
    }
}

