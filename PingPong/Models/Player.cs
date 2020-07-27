using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PingPong.Models
{
    public class Player
    {
        public int ID { get; set; }
        public int? TeamID { get; set; }//can be null
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool RightHand { get; set; }
        [DisplayName ("Birth Date")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get { return Convert.ToInt32(((DateTime.Now - DateOfBirth).TotalHours)/8760); } }
        public string Secret { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Team> Teams { get; set; } //player can have multiple teams, or none.
    }
}