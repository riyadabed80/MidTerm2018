using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MidTerm2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Cash c = new Cash();
            Check lol = new Check();



            string[] Names = new string[] { "Sophia ", "Olivia ", "Emma " };
            string[] StaticCategory = new string[] { "Drinks", "Food", "Merchandise" };
            Random numbering = new Random();
            int index = numbering.Next(3);
            Console.WriteLine("\t\t\tWelcome to Detroit Coffee Shop");
            Console.WriteLine($"This is {Names[index]}, How can I help you?\n");
            List<Products> Searching = FileEdit.ReadingList();

            List<Products> ICart = new List<Products>();


            Console.Write($"{"==========",-15}");
            Console.WriteLine($"{"==========",-10}");


            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"Please choose a category: \n(1).  Drinks \n(2).  Food \n(3).  Merchandise");
                int input = ValidateNum();
                int counter = 0;
                foreach (var item in Searching)
                {
                    if (item.Category == (StaticCategory[input - 1]))
                    {

                        counter++;
                        Console.WriteLine($"{counter}: {item.Name} {item.Price}");
                    }
                }

                Console.WriteLine("Please pick a number to add to your cart");
                int userPickIndex = int.Parse(Console.ReadLine());
                if (input == 3)
                {
                    if (userPickIndex > 7 || userPickIndex < 1)
                    {
                        Console.WriteLine("Please enter number between 1 and 7");
                    }
                    else
                    {
                        ICart.Add(Searching[userPickIndex + 14]);

                    }
                }
                else if (input == 2)
                {
                    if (userPickIndex > 10 || userPickIndex < 1)
                    {
                        Console.WriteLine("Please enter number between 1 and 10");
                    }
                    else
                    {
                        ICart.Add(Searching[userPickIndex + 4]);
                    }
                }
                else if (input == 1)
                {
                    if (userPickIndex > 5 || userPickIndex < 1)
                    {
                        Console.WriteLine("Please enter number between 1 and 5");
                    }
                    else
                    {
                        ICart.Add(Searching[userPickIndex - 1]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter a valid number");
                    userPickIndex = int.Parse(Console.ReadLine());
                }
                //save the user selection

                double total = 0.0;
                if (ICart.Count == 0)
                {
                    Console.WriteLine($"Your cart contains No item ");
                    foreach (var item in ICart)
                    {
                        Console.WriteLine($"{item.Name} {item.Price,0:C}");
                        total = total + (item.Price * 1.06 / 100) + item.Price;
                    }
                }
                else if (ICart.Count == 1)
                {
                    Console.WriteLine($"Your cart contains ({ICart.Count}) item ");
                    foreach (var item in ICart)
                    {
                        Console.WriteLine($"{item.Name} {item.Price,0:C}");
                        total = total + (item.Price * 1.06 / 100) + item.Price;
                    }
                }
                else
                {
                    Console.WriteLine($"Your cart contains ({ICart.Count}) items ");
                    foreach (var item in ICart)
                    {
                        Console.WriteLine($"{item.Name} {item.Price,0:C}");
                        total = total + (item.Price * 1.06 / 100) + item.Price;
                    }
                }


                Console.WriteLine("Would you like to add more? y/n");

                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "y")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine($"Your total is: {total,0:C} ");
                    Console.WriteLine("Please choose a payment method: (1)Cash  (2)Credit  (3)Check");
                    string payOption = Console.ReadLine();
                    if (payOption == "1")
                    {
                        Console.WriteLine("Please enter amount tendered");
                        double amountTendered = double.Parse(Console.ReadLine());
                        Cash cash = new Cash(total, amountTendered);
                        Console.WriteLine($"{cash.GetChange(),0:C}");
                    }
                    else if (payOption == "2")
                    {

                        Console.WriteLine("Please enter 16 digit card number: ");
                        string ccn = Console.ReadLine();
                        bool tryagain = true;
                        while (tryagain)
                        {
                            if (Regex.IsMatch(ccn, @"^(?:\d[-]*?){16}$"))
                            {
                                Console.WriteLine("Your card was accepted.  Thank you");
                                tryagain = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid card number. Please reenter credit card number");
                                ccn = Console.ReadLine();

                            }
                        }

                    }
                    else if (payOption == "3")
                    {
                        Console.WriteLine("Please enter your 9 digit check number");
                        string checkNum = Console.ReadLine();
                        bool checkagain = true;
                        while (checkagain)
                        {
                            if (Regex.IsMatch(checkNum, @"^\d{7}(\d{2})?$"))
                            {

                                Console.WriteLine("Check accepted. Thank you!");
                                checkagain = false;

                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid check number");
                                checkNum = Console.ReadLine();
                            }
                        }

                    }
                    repeat = false;
                }
                Console.WriteLine("Have a great day!");
            }
        }

        private static int ValidateNum()
        {
            int menuInput;
            while (!int.TryParse(Console.ReadLine(), out menuInput) || menuInput < 1 || menuInput > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid number between 1 and 3");
            }

            return menuInput;
        }


    }
}