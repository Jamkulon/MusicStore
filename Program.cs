using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore
{
    public abstract class Instrument
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int SerialNumber { get; set; }


        //public Instrument(string make, string model, decimal price, int serialNumber)
        //{
        //    Make = make;
        //    Model = model;
        //    Price = price;
        //    SerialNumber = serialNumber;
        //}

    }

    public class Guitar : Instrument
    {
        private string make;
        private string model;
        private decimal price;
        private int serialNumber;
        private int numOfStrings;

        public Guitar(string make, string model, decimal price, int serialNumber, int numOfStrings)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.SerialNumber = serialNumber;
            this.NumOfStrings = numOfStrings;
        }

        public int NumOfStrings { get; set; }
    }

    public class Bass : Guitar
    {
        public string BodyDesign { get; set; }

    }

    public class Drum : Instrument
    {
        public int NumOfDrums { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Guitar SG = new Guitar("Gibson", "SG", 2499.99m, 465215, 6);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
