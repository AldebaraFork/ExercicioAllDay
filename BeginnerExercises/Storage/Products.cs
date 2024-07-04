using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Storage
{
    public class Products
    {
        
            public string ProductName;
            public short id;
            public string ProductDescription;
            public string ProductCategory;
            public double ProductPrice;
            public int ProductCount;
             
            
            public double PriceXCount(double totalValor)
            {
                Console.WriteLine("Please Enter the Product count:");
                ProductCount = int.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("Ok, the count is: " +  ProductCount+ ", now enter the product price: ");
                ProductPrice = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                totalValor = ProductCount * ProductPrice;
                Console.WriteLine("The quantity of products in price is: $" + totalValor.ToString("F2",CultureInfo.InvariantCulture) );

                return totalValor;
            }
    }
}
