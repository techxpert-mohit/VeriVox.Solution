using System;
using System.Collections.Generic;
using System.Text;

namespace Verivox.Solution
{
    public class ProductWrapper : Products
    {
        List<Products> products = null;
        Products product = null;
        public ProductWrapper()
        {
            if (products == null)
            {
                products = new List<Products>();
            }
            if (product == null)
            {
                product = new Products();
            }
        }
        public List<Products> CalculateAnnualCost(int consumption)
        {
            var productACost = base.AnnualCostProductA(consumption);
            var productBCost = base.AnnualCostProductB(consumption);
            if (productACost <= productBCost)
            {
                product.TarrifName = "basic electricity tariff";
                product.AnnualCosts = $"{productACost} (pound/year)";
                products.Add(product);

                product = new Products();
                product.TarrifName = "Packaged tariff";
                product.AnnualCosts = $"{productBCost} (pound/year)";
                products.Add(product);
            }
            else if (productBCost < productACost)
            {
                product.TarrifName = "Packaged tariff";
                product.AnnualCosts = $"{productBCost} (pound/year)";
                products.Add(product);

                product = new Products();
                product.TarrifName = "basic electricity tariff";
                product.AnnualCosts = $"{productACost} (pound/year)";
                products.Add(product);
            }
            return products;
        }
    }

    
}
