using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2018
{
    class Cash : Payment
    {
        #region DataMembers
        private double amountTendered;
        private double change;
        #endregion

        #region Properties
        public double AmountTendered
        {
            set { amountTendered = value; }
            get { return amountTendered; }
        }
        public double Change
        {
            set { change = value; }
            get { return change; }
        }

        #endregion

        #region Constructors
        public Cash()
        {

        }

        public Cash(double Total, double cash) : base(Total)

        {
            Change = cash;
        }

        #endregion

        #region
        public double GetChange()
        {
            Change = (AmountTendered - Total);
            return Change;
        }
        #endregion
    }
}
