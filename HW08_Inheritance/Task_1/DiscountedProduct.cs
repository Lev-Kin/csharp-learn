namespace ProjectCSharp
{
    class DiscountedProduct : Product
    {
        public const int QuantityForDiscount = 10;
        private decimal discount;

        public decimal Discount { get => discount; set => discount = value; }

        public DiscountedProduct(string name, decimal price, int quantity, decimal discount) : base(name, price, quantity)
        {
            this.discount = discount;
        }

        public override decimal GetCost()
        {
            if (discount > 100)
            {
                throw new System.Exception("Скидка не может быть больше 100%!");
            }

            if (Quantity >= QuantityForDiscount)
            {
                return (decimal.Round(Price * Quantity * (1 - discount / 100)));
            }

            return base.GetCost();
        }

        public override string ToString()
        {
            return (base.ToString() + QuantityForDiscount + ";" + discount + ";" + GetCost() + ";");
        }
    }
}
