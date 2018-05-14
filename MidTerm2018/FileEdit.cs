using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MidTerm2018;
using System;

namespace Mid_Term_Project
{
    class FileEdit
    {
        public static List<Product> Menuing()
        {

            //read from text file
            StreamReader Reader = new StreamReader("../../Products.txt");
            //empty list

            List<Product> products = new List<Product>();
            //save the text file in single string format
            string line = Reader.ReadLine();

            while (!String.IsNullOrEmpty(line))
            {
                string[] LinebyLine = line.Split('|');

                products.Add(new Product(LinebyLine[0], LinebyLine[1], LinebyLine[2], (double.Parse(LinebyLine[3]))));

                line = Reader.ReadLine();
            }
            return products;

        }
    }
}

