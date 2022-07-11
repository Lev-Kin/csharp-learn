
namespace ProjectCSharp
{
    class Оutlay : AbstractPurchase
    {
        public decimal Expenses { get; set; }

        public Оutlay(decimal expenses, int quantity, Commodity product) : base(quantity, product)
        {
            Expenses = expenses;
        }

        public override decimal GetCost()
        {
            return Quantity * (product.Price + Expenses);
        }

        public override AbstractPurchase Clone(int quantity, Commodity product)
        {
            return new Оutlay(Expenses, quantity, product);
        }

        public override string ToString()
        {
            return base.ToString() + "расходы: " + Expenses + " руб.";
        }
    }
}
