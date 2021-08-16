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
            this.Name = name;
            this.PriceAtStart = priceAtStart;
            this.AmountAtStart = amountAtStart;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"{this.Name}, price {this.PriceAtStart}, amount {this.AmountAtStart}");
        }

        public void ChangeQuantity(int newQuantity)
        {
            this.AmountAtStart = newQuantity;
        }
        public void ChangePrice(double newPrice)
        {
            this.PriceAtStart = newPrice;
        }
    }
    class Program
    {      
        static void Main(string[] args)
        {
            var product1 = new Product("Logitech mouse", 70.00, 14);
            
            product1.PrintProduct();
            product1.ChangeQuantity(5);
            product1.ChangePrice(35.00);
            product1.PrintProduct();
            
        }
    }
}
