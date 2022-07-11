namespace ProjectCSharp
{
    class Product
    {
        private string name;
        private decimal price;
        private int quantity;

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Product(){}
        public Product(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        virtual public decimal GetCost()
        {
            return (price * quantity);
        }

        public override string ToString()
        {
            return (name + ";" + price + ";" + quantity + ";");
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }


            if (obj == null || (GetType() != obj.GetType()))
            {
                return false;
            }

            Product product = (Product)obj;

            if (price != product.price)
            {
                return false;
            }

            return name.Equals(product.name);
        }

        public override int GetHashCode()
        {
            return (name.GetHashCode() + price.GetHashCode());
        }
    }
}
