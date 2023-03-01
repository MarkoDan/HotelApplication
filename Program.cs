namespace HotelApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Bathroom bathroom = new Bathroom();
            Bedroom bedroom = new Bedroom();

            Console.Write("Owners Name: ");
            string ownersName = Console.ReadLine();
            Owner owner = new Owner(ownersName);
            Console.WriteLine($"Welcome {ownersName}");

            Console.Write("Name of the Hotel: ");
            string hotelsName = Console.ReadLine();
            Console.Write("Number of floors: ");
            int numberOfFloors = Convert.ToInt32(Console.ReadLine());
            int[] numberOfRooms = new int[numberOfFloors];

            for (int i = 0; i < numberOfFloors; i++)
            {
                Console.Write($"Number of rooms at floor_{i + 1}: ");
                int numberOfRoomsAtFloor = Convert.ToInt32(Console.ReadLine());
                numberOfRooms[i] = numberOfRoomsAtFloor;

            }
            int[] numberOfSubRooms = new int[numberOfFloors];
            for (int i = 0; i < numberOfRooms.Length; i++)
            {
                Console.Write($"Number of sub-rooms per room on floor_{i + 1}: ");
                int numSubRooms = Convert.ToInt32(Console.ReadLine());
                numberOfSubRooms[i] = numSubRooms;
            } 

            Hotel hotel = new Hotel(hotelsName, numberOfFloors, numberOfRooms, numberOfSubRooms);
            owner.Hotels.Add(hotel);

            Console.WriteLine(hotel);
            foreach (var item in hotel.Floors)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int TotalNumberOfRooms = 0;
            foreach (var item in numberOfRooms)
            {
                TotalNumberOfRooms += item;
            }
             

            Console.WriteLine("Do you want to fix some toilets? y/n");
            string chooseToFixToilet = Console.ReadLine();
            if (chooseToFixToilet != null)
            {
                Console.WriteLine($"Enter the number of the room (choose between {TotalNumberOfRooms})");
                int chooseRoom = Convert.ToInt32(Console.ReadLine());
                if (chooseRoom > TotalNumberOfRooms)
                {
                    Console.WriteLine("Room with the specified number does not exist");
                }
                else
                {
                    Plumber plumber = new Plumber(chooseRoom);
                    plumber.FixToilet();

                }
            }
            Console.WriteLine();
            Console.WriteLine("Now let me represent you our sub-rooms");
            Thread.Sleep(1000);
            Console.WriteLine(kitchen);
            Thread.Sleep(1000);
            Console.WriteLine(bathroom);
            Thread.Sleep(1000);
            Console.WriteLine(bedroom);
            Console.ReadKey();



        }
    }
}