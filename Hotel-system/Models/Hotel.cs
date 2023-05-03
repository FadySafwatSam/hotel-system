using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_system.Models
{
    public class Hotel
    {

      
        public int HotelId { get; set; }
        public String HotelName { get; set; }
        public String HotelLocation { get; set; }
        [NotMapped]
        public IEnumerable<String> HotelBranches { get; set; }
        [NotMapped]
        public IEnumerable<Room> HotelRooms { get; set; }



    }
}
