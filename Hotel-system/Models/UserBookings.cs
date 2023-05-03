using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Hotel_system.Models
{
    public class UserBookings
    {
       
        public int UserBookingsId { get; set; }
        public int RoomId { get; set; }
        public String UserId { get; set; }
        public int HotelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



    }
}
