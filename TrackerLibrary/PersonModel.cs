using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// the first name of the pearson.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// the last name of the parson.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// the email address of the pearson.
        /// </summary>
        public string EmailAddress { get; set; }
                
        /// <summary>
        /// the cellphone number of the pearson.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
