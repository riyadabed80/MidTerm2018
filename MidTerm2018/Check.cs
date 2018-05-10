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

        #region Default Constructor
        public Check ()
        {

        }
        #endregion

        #region Method Overload
        public Check (string check)
        {
            CheckNum = check;
        }
        #endregion



    }
}
