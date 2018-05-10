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
        public Payment(decimal TOTAL)
        {
            Total = TOTAL;
        }
        #endregion
        #region methods
        public abstract decimal GetChange();
        #endregion
    }
}
