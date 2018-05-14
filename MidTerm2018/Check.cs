using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public Check()
        {

        }

        public Check(double Total, string CheckNumber) : base(Total)
        {
            CheckNum = CheckNumber;
        }
        #endregion

        #region Method Overload
        public static bool Checking(string input)
        {
            string a = "";
            return (Regex.IsMatch(a, @"^([0-9]{9}"));

        }
        #endregion
        #region Method
        #endregion
    }
}