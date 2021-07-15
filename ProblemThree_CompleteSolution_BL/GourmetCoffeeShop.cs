using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    
        public class GourmetCoffeeShop : GourmetShop, ITaxCompute
        {
        double TotalBillValue;
        public  GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice) { 
        }
        public double PayPerPrice(int quantity) { 
        }

        public double PayPerWeight(int weight )
        {
        }

       public  double TaxOnTotalBill()
        {
        }
    


    }

}
