using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a - 1; i++)
            {
                Console.WriteLine("enter  type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }
            int totalPrice = TotalOrderValue(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int TotalOrderValue(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            int CounterofCD = 0;
            int priceofCD = 30;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            if (CounterofC > 0 && CounterofD > 0)
            {
                // if(CounterofC>CounterofD){
                // int CountofCExtra=CounterofC-CounterofD;
                // int priceOfCDDis=CountofCExtra*priceofC;
                // }
                CounterofCD = CounterofC + CounterofD;
            }

            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = 0;
            int totalPriceofD = 0;
            int totalPriceOfCD = 0;
            if (CounterofCD > 0)
            {
                if (CounterofC > CounterofD)
                {
                    totalPriceOfCD = (CounterofCD / 2) * 30 + (CounterofCD % 2 * priceofC);
                }
                else if (CounterofD > CounterofC)
                {
                    totalPriceOfCD = (CounterofCD / 2) * 30 + (CounterofCD % 2 * priceofD);
                }
                else
                {
                    totalPriceOfCD = (CounterofCD / 2) * 30 + (CounterofCD % 2 * priceofCD);
                }
            }
            else
            {
                totalPriceofC = (CounterofC * priceofC);
                totalPriceofD = (CounterofD * priceofD);
            }
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD + totalPriceOfCD;

        }

    }
}
