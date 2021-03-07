using System;
using System.Collections.Generic;

namespace Verivox.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductWrapper productWrapper = new ProductWrapper();
            List<Products> products = productWrapper.CalculateAnnualCost(3200);//Product A

            Console.WriteLine($" Product Name: {products[0].TarrifName} with an Annual Cost of {products[0].AnnualCosts} is cheaper!");

            products = new List<Products>();
            productWrapper = new ProductWrapper();
            products = productWrapper.CalculateAnnualCost(3500); //Product B
            Console.WriteLine($" Product Name: {products[0].TarrifName} with an Annual Cost of {products[0].AnnualCosts} is cheaper!");

            products = new List<Products>();
            productWrapper = new ProductWrapper();
            products = productWrapper.CalculateAnnualCost(6000); //Product A
            Console.WriteLine($" Product Name: {products[0].TarrifName} with an Annual Cost of {products[0].AnnualCosts} is cheaper!");

            products = new List<Products>();
            productWrapper = new ProductWrapper();
            products = productWrapper.CalculateAnnualCost(4500); //Product B
            Console.WriteLine($" Product Name: {products[0].TarrifName} with an Annual Cost of {products[0].AnnualCosts} is cheaper!");
        }
    }

}
