using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tracs.SyncWebsite.Models
{
    public class TransportTypes
    {
        public int TransportTypesID { get; set; }

        /// <summary>
        /// Name is title of TransportType 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Types of vehicles by motoric function - water, air, wheel, rail 
        /// </summary>
        public string MoveType { get; set; }
    }
}