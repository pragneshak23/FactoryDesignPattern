using System;

namespace FactoryDesignPattern
{
        public interface CreditCard
        {
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
        }
    
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            Console.WriteLine("Enter the card Type");
            string cardType = Console.ReadLine();

            CreditCard cardDetails = CreditCardfactory.GetCreditCard(cardType);   

                if (cardDetails != null)
                {
                    Console.WriteLine("CardType : " + cardDetails.GetCardType());
                    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
                }
                else
                {
                    Console.Write("Invalid Card Type");
                }

                Console.ReadLine();
            }
        }
    }
