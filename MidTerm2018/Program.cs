using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            ////StreamReader sr = new StreamReader("../../Merchandise.txt");
            ////string line = sr.ReadLine();
            ////while(line !=null)
            //{
            //    Console.WriteLine(line);
            //    line = sr.ReadLine();
            //}

            Console.WriteLine("Welcome to Grand Circus Coffee!");
            Console.WriteLine("Please choose a category: \n1.  Drinks \n2.  Food \n3.  Merchandise");

            int menuInput = ValidateNum();
            switch (menuInput)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Drinks\n\n1.  Coffee Dark Roast \n2.  Mocha Frappuccino \n3.  Iced Coffee \n4.  Teavana Green Tea  \n5.  Hot Chocolate");
                        int selection = int.Parse(Console.ReadLine());
                        switch (selection)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Great choice! We're would famous for our dark roast. How many would you like?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Mocha Frapp is my favorite! How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Ice in your coffee? Kinda weird, but we don't judge. How many would you like?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("We hear Green Tea is good for you! How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Our hot chocolate is just like mom used to make. How many would you like?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }


                        }
                        break;

                    }

                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Food\n\n1.  Cinnamon Roll \n2.  Chocolate Croissant \n3.  Cake Pops \n4.  Chocolate Chip Cookie \n5.  Banana Nut Bread \n6.  Breakfast Sandwich \n7.  Chicken Panini \n8.  Veggie Wrap \n9.  Strawberry Salad \n10. Yogurt  ");
                        int selection = int.Parse(Console.ReadLine());
                        switch (selection)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Sweet cinnamon and brown sugar.  I like how you think! How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("I always feel fancy eating a croissant. How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 3:
                                {
                                    
                                    break;
                                }
                            case 4:
                                {
                                    break;
                                }
                            case 5:
                                {
                                    break;
                                }
                            case 6:
                                {

                                    break;
                                }
                            case 7:
                                {
                                    break;
                                }
                            case 8:
                                {
                                    break;
                                }
                            case 9:
                                {
                                    break;
                                }
                            case 10:
                                {
                                    break;
                                }

                        }
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Merchandise\n\n1.  Coffee Mug \n2.  Travel Mug \n3.  T-Shirts \n4.  CoffeeMaker 3000 \n5.  $25 Gift Card \n6.  $50 Gift Card \n7.  $100 Gift Card");
                        int selection = int.Parse(Console.ReadLine());
                        switch (selection)
                        {
                            case 1:
                                {
                                    Console.WriteLine("This will be your new favorite mug! How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("You can take this travel mug anywhere. How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("This shirt would look great on you. How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("This machine has been rated #1 by CoffeeEnthusiast.com How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("$25 Gift Card. Someone's lucky. How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("$50 Gift Card. Someone's lucky.  How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("$100 Gift Card. Someone's lucky.  How many do you want?");
                                    int qty = int.Parse(Console.ReadLine());
                                    break;
                                }

                        }break;

                    }
            }



        }


        private static int ValidateNum()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }

            return input;
        }
    }
}