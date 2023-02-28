namespace HotelApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Owners Name: ");
            string ownersName = Console.ReadLine();
            Owner owner = new Owner(ownersName);
            Console.WriteLine($"Welcome {ownersName}");

            Console.Write("Name of the Hotel: ");
            string hotelsName = Console.ReadLine();
            Console.Write("Number of floors: ");
            int numberOfFloors = Convert.ToInt32(Console.ReadLine());
            int[] numberOfRooms = { };
            for (int i = 1; i <= numberOfFloors; i++)
            {
                Console.Write($"Number of rooms at floor_{i}: ");
                int numberOfRoomsAtFloor = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref numberOfRooms, i); // resize the array
                numberOfRooms[i - 1] = numberOfRoomsAtFloor; // add the new element

            }


            Hotel hotel = new Hotel(hotelsName, numberOfFloors, numberOfRooms);
            owner.Hotels.Add(hotel);

            Console.WriteLine(hotel);
            foreach (var item in hotel.Floors)
            {
                Console.WriteLine(item);
            }
        }
    }
}