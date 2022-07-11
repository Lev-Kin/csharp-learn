using System;

namespace ProjectCSharp
{
    abstract class AbstractPurchase : IComparable<AbstractPurchase>
    {
        protected Commodity product;
        protected int quantity;

        public AbstractPurchase(int quantity, Commodity product)
        {
            this.quantity = quantity;
            this.product = product;
        }

        public Commodity Product
        {
            get
            {
                return product;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
        }

        public abstract decimal GetCost();

        public abstract AbstractPurchase Clone(int quantity, Commodity product);

        public override string ToString()
        {
            return product.ToString() + "кол-во: " + Quantity + " шт.; ";
        }

        public int CompareTo(AbstractPurchase purchase)
        {
            return purchase.GetCost().CompareTo(this.GetCost());
        }

        public static AbstractPurchase operator +(AbstractPurchase obj1, AbstractPurchase obj2)
        {
            if (obj1.Product.Name != obj2.Product.Name)
                throw new Exception("Товары не одинаковые!!!");

            return obj1.Clone(obj1.Quantity + obj2.Quantity, obj1.Product);
        }
    }
}
