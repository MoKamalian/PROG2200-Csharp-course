using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        /* =================== PART 4 ==================== */
        /* the 'm' next to the numbers represents a decimal type of money form.
           So any number will be represented to the exact decimal value and 
           rounded to two decimal places using bankers rounding. 
           Note this is not the same as double. 
           
           https://stackoverflow.com/questions/977484/what-does-the-m-stand-for-in-c-sharp-decimal-literal-notation#:~:text=A%20real%20literal%20suffixed%20by,representable%20value%20using%20banker's%20rounding.
           */
        
        
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;

            /* =================== PART 2 ==================== */
            /* will give a 10$ discount to low risk areas with prices above 100$ */
            LowRiskDiscountDelegate lowDisc = delegate(ref decimal price, bool highRisk) {
                if (!highRisk) {
                    if (price > 100) {
                        price -= 10; 
                    }
                }
            };
            
            
            string theZone; 
            do
            {
                // get the destination zone
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();

                // if the user wrote "exit" then terminate the program,
                // otherwise continue 
                if (!theZone.Equals("exit"))
                {
                    // given the zone, retrieve the associated shipping info
                    theDest = ShippingDestination.getDestinationInfo(theZone);

                    // if there's no associated info, then the user entered
                    // an invalid zone, otherwise continue
                    if (theDest != null)
                    {
                        // ask for the price and convert the string to a decimal number
                        
                        /* =================== PART 1 ==================== */
                        /* validation for item price to check if it is a decimal */
                        Console.WriteLine("What is the item price?");
                        string thePriceStr = Console.ReadLine();
                        decimal itemPrice;
                        while (!decimal.TryParse(thePriceStr, out itemPrice)) {
                            Console.WriteLine("Please enter a valid decimal number: ");
                            thePriceStr = Console.ReadLine(); 
                        }
                        itemPrice = decimal.Parse(thePriceStr);

                        // Each ShippingDestination object has a function called calcFees,
                        // use that as the delegate for calculating the fee
                        theDel = theDest.calcFees;

                        // For high-risk zones, we tack on the delegate that adds more
                        if (theDest.m_isHighRisk)
                        {
                            theDel += delegate (decimal thePrice, ref decimal itemFee) {
                                itemFee += 25.0m;
                            };
                        }
                       

                        // now all that is left to do is call the delegate and output
                        // the shipping fee to the Console
                        decimal theFee = 0.0m;
                        theDel(itemPrice, ref theFee);
                        
                        
                        lowDisc(ref theFee, theDest.m_isHighRisk); 
                        
                        Console.WriteLine("The shipping fees are: {0}", theFee);
                    }
                    else
                    {
                        Console.WriteLine("Hmm, you seem to have entered an uknown destination. Try again or 'exit'");
                    }
                }
            } while (theZone != "exit");
        }
    }
}
