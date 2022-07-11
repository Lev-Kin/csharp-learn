namespace ProjectCSharp
{
    class Buy
    {
        public string Name { set; get; }
        public decimal Price { set; get; }
        public int Amount { set; get; }

        public Buy()
        {
            Name = "Коньяк 7 Звезд";
            Price = 77.77M;
            Amount = 1;
        }
        public Buy(string name, decimal price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public decimal GetCost()
        {
            return Price * Amount;
        }
        public override string ToString()
        {
            return "Покупка: " + Name + " ; " + Price + " ; " + Amount + " шт.";
        }
        public bool Equals(Buy obj)
        {
            return Name == obj.Name && Price == obj.Price;
        }

    }
}