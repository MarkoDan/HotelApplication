using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Floor
    {
        //private int i;
        //private int numRoomsPerFloor;

        public int FloorNumber { get; set; }
        public List<Room> Rooms { get; set; }

        public Floor(int floorNumber, int[] numRooms)
        {
            FloorNumber = floorNumber;
            Rooms = new List<Room>();
            for(int i = 1; i <= numRooms.Length; i++)
            {
                Rooms.Add(new Room(i));
            }
        }

        //public Floor(int i, int numRoomsPerFloor)
        //{
        //    this.i = i;
        //    this.numRoomsPerFloor = numRoomsPerFloor;
        //}

        public override string ToString()
        {
            return $"Floor {FloorNumber} has {Rooms.Count} rooms";
        }
    }
}
