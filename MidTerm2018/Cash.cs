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
        private decimal amountTendered;
        private decimal change;
        #endregion

        #region Properties
        public decimal AmountTendered
        {
            set { amountTendered = value; }
            get { return amountTendered; }
        }
        public decimal Change
        {
            set { change = value; }
            get { return change; }
        }

        #endregion

        #region Constructors
        public Cash()
        {

        }
        public Cash(decimal Total, decimal cash) : base(Total)
        {
            Change = cash;
        }

        #endregion

        #region
        public decimal GetChange()
        {
            Change = (AmountTendered - Total);
            return Change;
        }
        #endregion
    }
}
