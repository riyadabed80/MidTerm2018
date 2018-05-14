using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2018
{
    class Product
    {
        #region data members
        private string name;
        private string category;
        private string description;
        private double price;
        private double quantity;

        #endregion
        #region properties
        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        #endregion
        #region constructor

        public Product()
        {

        }

        public Product(string NAME, string CATEGORY, string DESCRIPTION, double PRICE)
        {
            Name = NAME;
            Category = CATEGORY;
            Description = DESCRIPTION;
            Price = PRICE;

        }
        #endregion
        #region methods
        // use a method to calculate the amount cost for the item by taking user input quantity 
        public double PriceForQuantity()
        {
            double pricequantity;
            return pricequantity = price * quantity;
        }
        #endregion

    }
}
