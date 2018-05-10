using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2018
{
    abstract class Payment
    {
        #region data members
        private decimal total;
        private decimal amountTendered;
        private 


        #endregion
        #region properties
        public decimal Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        
        #endregion
        #region constructor
        public Payment()
        {

        }
        #region
        public Payment(decimal TOTAL)
        {
            Total = TOTAL;
        }
        #endregion

    }
}
