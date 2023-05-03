using Hotel_system.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace E_Commerce.Data.Models
{
    public class DbInitializer
    {

        public static void seed(IServiceProvider serviceProvider) {
           
            AppDbContext context = serviceProvider.GetService<AppDbContext>();


            //applicationBuilder.ApplicationServices.GetService<AppDbContext>();
            //AppDbContext context = new AppDbContext();

            ////if (!context.Categories.Any()) {

            ////    context.Categories.AddRange();


            ////}
            ////if (!context.Items.Any())
            ////{

            ////    context.Items.AddRange();

            ////}
            ///
     

                if (!context.Rooms.Any()) {

                context.Rooms.AddRange(
                    new Room { 
                    Branche="A",
                    IsBooked=false,
                    HotelId= 1 ,
                    ImgUrl= "Images/room-1.jpg",
                    Price= 200,
                    RoomType= "single",

                    },
                             new Room
                             {
                                 Branche = "A",
                                 IsBooked = false,
                                 HotelId = 1,
                                 ImgUrl = "Images/room-2.jpg",
                                 Price = 250,
                                 RoomType = "double",

                             },
                                      new Room
                                      {
                                          Branche = "A",
                                          IsBooked = false,
                                          HotelId = 1,
                                          ImgUrl = "Images/room-4.jpg",
                                          Price = 150,
                                          RoomType = "single",

                                      },



                                               new Room
                                               {
                                                   Branche = "A",
                                                   IsBooked = false,
                                                   HotelId = 1,
                                                   ImgUrl = "Images/room-5.jpg",
                                                   Price = 300,
                                                   RoomType = "double",

                                               },

         new Room
         {
             Branche = "A",
             IsBooked = false,
             HotelId = 1,
             ImgUrl = "Images/room-6.jpg",
             Price = 500,
             RoomType = "suite",

         },


                  new Room
                  {
                      Branche = "A",
                      IsBooked = false,
                      HotelId = 1,
                      ImgUrl = "Images/room-7.jpg",
                      Price = 600,
                      RoomType = "suite",

                  },

         new Room
         {
             Branche = "A",
             IsBooked = false,
             HotelId = 1,
             ImgUrl = "Images/room-8.jpg",
             Price = 200,
             RoomType = "single",

         },


                  new Room
                  {
                      Branche = "B",
                      IsBooked = false,
                      HotelId = 1,
                      ImgUrl = "Images/room-9.jpg",
                      Price = 300,
                      RoomType = "single",

                  },

         new Room
         {
             Branche = "B",
             IsBooked = false,
             HotelId = 1,
             ImgUrl = "Images/room-10.jpg",
             Price = 300,
             RoomType = "single",

         },

                  new Room
                  {
                      Branche = "B",
                      IsBooked = false,
                      HotelId = 1,
                      ImgUrl = "Images/room-11.jpg",
                      Price = 400,
                      RoomType = "double",

                  },

                           new Room
                           {
                               Branche = "B",
                               IsBooked = false,
                               HotelId = 2,
                               ImgUrl = "Images/room-12.jpg",
                               Price = 250,
                               RoomType = "single",

                           },

         new Room
         {
             Branche = "B",
             IsBooked = false,
             HotelId = 2,
             ImgUrl = "Images/room-13.jpg",
             Price = 400,
             RoomType = "suite",

         },


                  new Room
                  {
                      Branche = "B",
                      IsBooked = false,
                      HotelId = 2,
                      ImgUrl = "Images/room-14.jpg",
                      Price = 500,
                      RoomType = "double",

                  },

         new Room
         {
             Branche = "B",
             IsBooked = false,
             HotelId = 2,
             ImgUrl = "Images/room-15.jpg",
             Price = 600,
             RoomType = "suite",

         },

                  new Room
                  {
                      Branche = "C",
                      IsBooked = false,
                      HotelId = 2,
                      ImgUrl = "Images/room-16.jpg",
                      Price = 500,
                      RoomType = "double",

                  },

                           new Room
                           {
                               Branche = "C",
                               IsBooked = false,
                               HotelId = 2,
                               ImgUrl = "Images/room-17.jpg",
                               Price = 350,
                               RoomType = "single",

                           },

         new Room
         {
             Branche = "C",
             IsBooked = false,
             HotelId = 2,
             ImgUrl = "Images/room-18.jpg",
             Price = 500,
             RoomType = "suite",

         },
                  new Room
                  {
                      Branche = "C",
                      IsBooked = false,
                      HotelId = 2,
                      ImgUrl = "Images/room-19.jpg",
                      Price = 250,
                      RoomType = "single",

                  },

                           new Room
                           {
                               Branche = "C",
                               IsBooked = false,
                               HotelId = 2,
                               ImgUrl = "Images/room-20.jpg",
                               Price = 200,
                               RoomType = "single",

                           },


         new Room
         {
             Branche = "C",
             IsBooked = false,
             HotelId = 2,
             ImgUrl = "Images/room-21.jpg",
             Price = 250,
             RoomType = "single",

         } ,
                  new Room
                  {
                      Branche = "C",
                      IsBooked = false,
                      HotelId = 2,
                      ImgUrl = "Images/room-22.jpg",
                      Price = 270,
                      RoomType = "single",

                  }



                    );
            
            }


            if (!context.Hotels.Any()) {

                context.Hotels.AddRange(

                       new Hotel
                       {
                           HotelLocation="london",
                           HotelName="londonHotel",
                         
                           

                       },
                            new Hotel
                            {
                                HotelLocation = "paris",
                                HotelName = "parisHotel",



                            }

                    );
            
            
            }

            context.SaveChanges();

        }


    }
}
