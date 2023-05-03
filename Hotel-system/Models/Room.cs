using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_system.Models
{
    public class Room
    {

        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public String Branche { get; set; }
        public String RoomType { get; set; }
        public double Price { get; set; }
        public double PriceAfterDiscount { get => Price-(0.95*Price) ; }
        public String ImgUrl { get; set; }
        public bool IsBooked { get; set; }






    }
}
