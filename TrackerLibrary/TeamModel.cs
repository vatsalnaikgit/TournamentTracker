using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents team list
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// team member list in a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
        /// <summary>
        /// Team name.
        /// </summary>
        public string TeamName { get; set; }
    }
}
