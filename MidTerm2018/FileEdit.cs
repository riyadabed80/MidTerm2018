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
            StreamReader Bev = new StreamReader("../../Products.txt");
            //save the text file in single string format
            string bevline = Bev.ReadLine();
            //empty list of a Products class
            List<Products> Bevs = new List<Products>();
            while (!String.IsNullOrEmpty(bevline))
            {
                string[] LinebyLine = bevline.Split('|');
                Bevs.Add(new Products(LinebyLine[0], LinebyLine[1], LinebyLine[2], double.Parse(LinebyLine[3])));
                bevline = Bev.ReadLine();
            }
            Bev.Close();
            return Bevs;
        }
        public static List<Products> FoodList()
        {
            StreamReader Food = new StreamReader("../../Food.txt");
            string foodline = Food.ReadLine();
            List<Products> Foods = new List<Products>();
            while (!String.IsNullOrEmpty(foodline))
            {
                string[] LinebyLine = foodline.Split('|');
                Foods.Add(new Products(LinebyLine[0], LinebyLine[1], LinebyLine[2], double.Parse(LinebyLine[3])));
                foodline = Food.ReadLine();

            }
            Food.Close();
            return Foods;
        }
        public static List<Products> MerchList()
        {
            StreamReader Merch = new StreamReader("../../Merchandise.txt");
            string merchline = Merch.ReadLine();
            List<Products> Merchs = new List<Products>();
            while (!String.IsNullOrEmpty(merchline))
            {
                string[] LinebyLine = merchline.Split('|');
                Merchs.Add(new Products(LinebyLine[0], LinebyLine[1], LinebyLine[2], double.Parse(LinebyLine[3])));
                merchline = Merch.ReadLine();
            }
            Merch.Close();
            return Merchs;
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

