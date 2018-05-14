using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MidTerm2018;
using System;


namespace MidTerm2018
{
    class FileEdit
    {
        public static List<Products> ReadingList()
        {
            //read from text file
            StreamReader Reader = new StreamReader("../../Products.txt");

            //save the text file in single string format
            string line = Reader.ReadLine();
            //empty list of a Products class
            List<Products> Allproducts = new List<Products>();

            while (!String.IsNullOrEmpty(line))
            {
                string[] LinebyLine = line.Split('|');

                Allproducts.Add(new Products(LinebyLine[0], LinebyLine[1], LinebyLine[2], double.Parse(LinebyLine[3])));

                line = Reader.ReadLine();
            }
            Reader.Close();
            return Allproducts;
        }

        public static void WritingList(List<Products> WritingMethod)
        {
            StreamWriter Writer = new StreamWriter("../../Products.txt", false);

            foreach (Products p in WritingMethod)
            {
                Writer.WriteLine($"{p.Category}|{p.Name}|{p.Description}|{p.Price}");
            }
            Writer.Close();
        }
    }
}

