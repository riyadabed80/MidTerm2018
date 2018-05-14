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

        private double total;


        #endregion
        #region properties
        public double Total
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

        public Payment(double TOTAL)
        {
            Total = TOTAL;
        }

        #endregion

    }
}
