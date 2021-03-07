using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;


namespace Verivox.Solution
{
    public class Products
    {
        public string TarrifName { get; set; }
        public string AnnualCosts { get; set; }

        private double costParameter = 0;
        private int baseCost = 0;

        protected int AnnualCostProductA(int consumption)
        {
            int tarrif;
            costParameter = Convert.ToDouble(ConfigurationManager.AppSettings["ProductACostParameter"]);
            baseCost = Convert.ToInt32(ConfigurationManager.AppSettings["ProductABaseCost"]);
            tarrif = baseCost + Convert.ToInt32(consumption * costParameter);
            return tarrif;
        }

        protected int AnnualCostProductB(int consumption)
        {
            int tarrif;
            var staticConsumption = Convert.ToInt32(ConfigurationManager.AppSettings["ProductBStaticConsumption"]);
            baseCost = Convert.ToInt32(ConfigurationManager.AppSettings["ProductBBaseCost"]); 
            costParameter = Convert.ToDouble(ConfigurationManager.AppSettings["ProductBCostParameter"]);
            if (consumption <= staticConsumption)
            {
                tarrif = baseCost;
            }
            else
            {
                var additionalConsumption = consumption - staticConsumption;
                tarrif = baseCost + Convert.ToInt32(additionalConsumption * costParameter);
            }
            return tarrif;
        }
    }
}
