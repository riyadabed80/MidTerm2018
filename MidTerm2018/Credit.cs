﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2018
{
    class Credit : Payment
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

        }
        public Credit(string card, string expir, string cvv, decimal total) : base(total)
        {
            CardNumber = card;
            ExpDate = expir;
            CVV = cvv;

        }
        #endregion
    }

}
