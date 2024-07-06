namespace Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Aldebara store! please enter a number to continue: ");
            Console.WriteLine("1 - Check product count x Product price");
            Console.WriteLine("2 - Add a product to stock ");
            Console.WriteLine("3 - Verify if product is avaliable");
            Console.WriteLine("4 - Check price in R$");
            int SelectedOption = int.Parse(Console.ReadLine());
            switch (SelectedOption)
            {
                case 1:
                    Console.Clear();
                    var producto = new Products();
                    producto.PriceXCount(0);
                    break;
                case 2:
                    Console.Clear();
                    AddProduct addProduct = new AddProduct();
                    addProduct.AddProducts();
                    break;
                 default:
                    Console.WriteLine("please enter a valid number");
                    break;
            }
        }
    }

}
