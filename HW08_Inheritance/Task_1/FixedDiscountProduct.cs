namespace ProjectCSharp
{
    class FixedDiscountProduct : Product
    {
        private decimal discountInRub;

        public decimal DiscountInRub { get => discountInRub; set => discountInRub = value; }

        public FixedDiscountProduct(string name, decimal price, int quantity, decimal discountInRub) : base(name, price, quantity)
        {
            this.discountInRub = discountInRub;
        }

        public override decimal GetCost()
        {
            if (discountInRub > Price)
            {
                throw new System.Exception("Скидка не может быть больше цены!");
            }

            if (discountInRub > 0)
            {
                return (decimal.Round((Price - discountInRub) * Quantity));
            }
            else
            {
                return base.GetCost();
            }
        }

        public override string ToString()
        {
            return (base.ToString() + discountInRub + ";" + GetCost() + ";");
        }
    }
}
