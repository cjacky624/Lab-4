using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Final
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer greater than 1");

                string userInput = Console.ReadLine();
                int userNum = int.Parse(userInput);

                Console.WriteLine("\n");
                Console.WriteLine("Number          Squared          Cubed");
                Console.WriteLine("======          =======          =====");
                for (int i = 1; i <= userNum; i++)
                {
                    Console.WriteLine("{0}                {1}                 {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
                }

                Console.WriteLine("Would you like to continue entering integers? (Y/N)");
                userInput = Console.ReadLine().ToUpper();
                if (userInput == "N")
                {
                    break;
                }
            }
        }
    }
}   
