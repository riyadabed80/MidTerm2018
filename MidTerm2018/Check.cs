using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2018
{
    class Check : Payment
    {
        #region Data Members
        private string checkNum;
        #endregion
        #region Properties
        public string CheckNum
        {
            get { return checkNum; }
            set { checkNum = value; }
        }
        #endregion
        #region constructor
        public Check()
        {

        }
        public Check(decimal Total, string CheckNumber) :base(Total)
        {
            CheckNum = CheckNumber;
        }
        #endregion
        #region Method
        #endregion
    }
}
