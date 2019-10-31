using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_31_Part
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }
        public double Price { get; set;}

        private string Aisle { get; set;}

      
        private string GetAisle()
        {
            char firstLetter = Manufacturer[0];

            Random rand = new Random();
            int randNumb = rand.Next(1, 25);

            string sentence = $"{firstLetter}{randNumb}";

            return sentence;

        }
          
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Aisle = string.Empty;
        }
        




    }


}
