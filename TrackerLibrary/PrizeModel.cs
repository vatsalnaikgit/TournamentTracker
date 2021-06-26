using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents prize for the winner
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// 
        /// </summary>    
        public int PlaceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// price amount in $.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// prize amount in the percentage
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
