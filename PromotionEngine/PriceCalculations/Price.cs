using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Price
    {
        public int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0, counterofB = 0, CounterofC = 0, CounterofD = 0;
            
            int priceofA = 50, priceofB = 30, priceofC = 20, priceofD = 15;           

            foreach (Product pr in products)
            {
                if (pr.Id == "A")
                    counterofA = counterofA + 1;

                else if (pr.Id == "B")
                    counterofB = counterofB + 1;

                else if (pr.Id == "C")
                    CounterofC = CounterofC + 1;

                else if (pr.Id == "D")
                    CounterofD = CounterofD + 1;
            }

            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);

            if (CounterofC >= 1 && CounterofD >= 1)
            {
                int totalPriceofCandD = 0;

                if (CounterofC == CounterofD)
                    totalPriceofCandD = CounterofC * 30;
                else
                    totalPriceofCandD = CounterofC > CounterofD ?
                                                CounterofD * 30 + (CounterofC - CounterofD) * 20
                                                : CounterofC * 30 + (CounterofD - CounterofC) * 15;

                return totalPriceofA + totalPriceofB + totalPriceofCandD;                
            }

            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);

            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;            
        }
    }
}
