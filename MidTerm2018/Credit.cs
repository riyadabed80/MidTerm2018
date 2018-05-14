using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2018
{
    class Credit
    {
        #region Data Members
        private string cardNumber;
        private string expDate;
        private string cvv;
        #endregion

        #region Properties
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public string ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }

        public string CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }
        #endregion

        #region Constructor
        public Credit()
        {
            CardNumber = "1234123412341234";
            CVV = "123";
            ExpDate = "05/19";
        }
        public Credit(string card, string expir, string cvv)
        {
            CardNumber = card;
            ExpDate = expir;
            CVV = cvv;

        }

         #endregion
        public void EncryptCCN()
        {
            Console.WriteLine("Please input your credit card number(16 digits).");
            string CardNumber = Console.ReadLine();
            Console.WriteLine("Please input CVV");
            string CCV = Console.ReadLine();
            Console.WriteLine("Please input expiration");
            string ExpDate = Console.ReadLine();
            bool tryagain = true;
            while (tryagain)
            {
                if (CardNumber.Length == 16 & CCV.Length == 3 & ExpDate.Length == 5 )
                {
                    CardNumber = CardNumber.Remove(0, 12);
                    Console.WriteLine("************" + CardNumber);
                    Console.WriteLine(CCV);
                    Console.WriteLine(ExpDate);
                    Console.WriteLine("Your card was accepted. Thank you");
                    tryagain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input.\nPlease reenter credit card number");
                    CardNumber = Console.ReadLine();
                    Console.WriteLine("Please reenter your CVV.");
                    CCV = Console.ReadLine();
                    Console.WriteLine("Please reenter your expiration date.");
                    ExpDate = Console.ReadLine();


                }
            }


        }
    }
}




    













