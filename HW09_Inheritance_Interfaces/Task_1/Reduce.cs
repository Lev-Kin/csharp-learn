
namespace ProjectCSharp
{
    class Reduce : AbstractPurchase
    {
        public double Discount { get; set; }

        public Reduce(double discount, int quantity, Commodity product) : base(quantity, product)
        {
            Discount = discount;
        }

        public override decimal GetCost()
        {
            return product.Price * Quantity - (product.Price * Quantity * (decimal)Discount / 100);
        }

        public override AbstractPurchase Clone(int quantity, Commodity product)
        {
            return new Reduce(Discount, quantity, product);
        }

        public override string ToString()
        {
            return base.ToString() + "скидка: " + Discount + "%";
        }
    }
}
