namespace Exercise1
{
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
