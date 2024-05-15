using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Storage
{
    internal class AddProduct
    {

        public string ProductName;
        public int ProductCount;
        public int StockCount ;
        public double PriceInStock;
        public double ProductPrice;

        public void AddProducts()
        {
            //add product to stock
            Console.WriteLine("which product you want add to stock? ");
            ProductName = Console.ReadLine();
            Console.WriteLine("please insert the price of: " + ProductName);
            ProductPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("How many items you want to add? ");
            ProductCount = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             PriceInStock = ProductCount * ProductPrice;
            Console.WriteLine("Total price of " + ProductName + " in stock is: " + PriceInStock.ToString("f2",CultureInfo.InvariantCulture));

            // add more products?

            Console.WriteLine("You want to add more " + ProductName + " to stock? Y/N");
            string SelectedOption = Console.ReadLine();
            if (SelectedOption == "Y" || SelectedOption == "y")
            {
                Console.WriteLine("There is " + ProductCount + " " + ProductName + " in stock how much more products you want to add?");
                int MoreProduct = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                StockCount = ProductCount + MoreProduct;
                Console.WriteLine("Total quantity of products in stock: " + StockCount);
                PriceInStock = StockCount * ProductPrice;
                Console.WriteLine("Total Price in stock:  $" + PriceInStock);

            }else if (SelectedOption == "N" || SelectedOption == "n")
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
          
            

        }





    }
}
