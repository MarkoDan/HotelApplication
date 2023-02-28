using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            IsOccupied = false;
        }
    }
}
