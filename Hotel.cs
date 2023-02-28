using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Hotel
    {
        //private string? hotelsName;
        //private int numberOfFloors;
        //private int[] numberOfRooms;

        public string Name { get; set; }
        public int NumFloors { get; set; }
        public int[] NumRoomsPerFloor { get; set; }
        public List<Floor> Floors { get; set; }

        public Hotel(string name, int numFloors, int[] numRoomsPerFloor)
        {
            Name = name;
            NumFloors = numFloors;
            NumRoomsPerFloor = numRoomsPerFloor;    
            Floors = new List<Floor>();
            for(int i = 1; i <= numFloors; i++)
            {
                Floors.Add(new Floor(i, NumRoomsPerFloor));   
            } 
        }

        //public Hotel(string? hotelsName, int numberOfFloors, int[] numberOfRooms)
        //{
        //    this.hotelsName = hotelsName;
        //    this.numberOfFloors = numberOfFloors;
        //    this.numberOfRooms = numberOfRooms;
        //}

        public override string ToString()
        {
            return $"Hotel {Name} has {NumFloors} floors!";
        }
    }
}
