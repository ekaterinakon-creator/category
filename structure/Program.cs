using System;
namespace structure
{
    internal class Program
    {
        struct Hotel
    {
        string name;
      sbyte numberOfRooms;
        string category;
            uint price;
        public Hotel(string name, sbyte numberOfRooms, string category, uint price)
        {
            this.name = name;
            this.numberOfRooms = numberOfRooms;
            this.category = category;
            this.price = price;
            PrintInfo();
        }
        void PrintInfo()
        {
            Console.WriteLine("\t\n----Информация о гостинице----");
            Console.Write($"\n\tНазвание: {name}" +
            $"\n\tКоличество комнат: {numberOfRooms}" +
            $"\n\tКатегория: {category}" +
            $"\n\tЦена: {price}");
        }
    }
        static Hotel CreateHotelInfoForPrint()
        {
            Console.Write("Введите название отеля: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество комнат: ");
            sbyte numberOfRooms = Convert.ToSByte(Console.ReadLine());
            Console.Write("Введите категорию: ");
            string category = Console.ReadLine();
            Console.Write("Введите цену: ");
            uint price = Convert.ToUInt32(Console.ReadLine());
            return new Hotel(name, numberOfRooms, category, price);
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Hotel hotel = CreateHotelInfoForPrint();
            Console.ReadKey();
        }
    }
}
