using System;
namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public byte Year { get; set; }



        public Car()
        {
            this.Make = "nothing yet";
           this. Model = "nothing yet";
            this.Color = "nothing yet";
            this.Price = 0.00M;
            this.Year = 0;

        }


        public Car(string a,string b,decimal c,byte e,string d)
        {
            Make = a;
            Model = b;
            Price = c;
            Year = e;
            Color = d;

        }

        public override string ToString()
        {
            return "Make: "+ Make + "Model : " +Model + "Price: $"+ Price + "Color: $" + Color +  "Year: $" + Year; ;
        }


    }
}
