using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("Axe", "12345", 23, 12);
            Item item3 = new Item("Shotgun", "12334567", 3, 4);
            Item item2 = new Item("Shovel", "945687893112", 1, 8);
            Item item4 = new Item("Rifle", "8567123", 15, 100);
            // Item item5 = new Item("Rifle", "8567123", 15,100);
            Inventory inventory1 = new Inventory();


            inventory1.AddItem(item1);
            inventory1.AddItem(item2);
            inventory1.AddItem(item3);
            inventory1.AddItem(item4);

            Console.WriteLine(inventory1);

            Console.WriteLine("-------------------");
            inventory1.DeleteItem(item1);
            Console.WriteLine(inventory1);

            Console.WriteLine("-------------------\n");


            string fileNameJSON = "Items.json";
            string fileNameBinary = "Items.bin";


            FileManager.SerializationJSON(inventory1, fileNameJSON);
            FileManager.SerializationBinary(inventory1, fileNameBinary);



            Inventory inventory2 = FileManager.DeserializationJSON(fileNameJSON);
            Console.WriteLine("Десириализация инвентаря из JSON");
            Console.WriteLine(inventory2);


            Inventory inventory3 = FileManager.DeserializationBinary(fileNameBinary);
            Console.WriteLine("Десириализация инвентаря из binary");
            Console.WriteLine(inventory3);

            Console.ReadLine();
        }
    }
}