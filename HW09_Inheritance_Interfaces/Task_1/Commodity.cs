using System;

namespace ProjectCSharp
{
    class Commodity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int ShelfLife { get; set; }

        public Commodity(string name, decimal price, int shelflife, DateTime date = new DateTime())
        {
            Name = name;
            Price = price;
            Date = date;
            ShelfLife = shelflife;
        }

        public DateTime GetExpirationDate()
        {
            return Date.AddDays(ShelfLife);
        }

        public override string ToString()
        {
            return Name + "; " + Price + " руб." + "; " + Date.ToShortDateString() + "; годен: " + ShelfLife + " дней; ";
        }
    }
}
