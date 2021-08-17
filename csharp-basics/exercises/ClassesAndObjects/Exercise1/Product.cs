using System;

namespace Exercise1
{
    public class Product
    {
        public string Name;
        public double PriceAtStart;
        public int AmountAtStart;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            PriceAtStart = priceAtStart;
            AmountAtStart = amountAtStart;
        }
        public string PrintProduct()
        {
            return $"{Name}, price {PriceAtStart}, amount {AmountAtStart}";
        }

        public int ChangeQuantity(int newQuantity)
        {
            return AmountAtStart = newQuantity;
        }
        public double ChangePrice(double newPrice)
        {
            return PriceAtStart = newPrice;
        }
    }
}
