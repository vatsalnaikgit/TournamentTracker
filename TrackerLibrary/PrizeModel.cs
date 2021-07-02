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
        /// The unique identifier for the prizes.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The numeric identifier for the place, etc. 
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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
