using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args) //main method
        {
            
            string input1, input2, op;
            int value1, value2, result = 0;
            string ans;
           
            do
            {
                do
                {
                    Console.WriteLine("Enter Value 1: ");
                    input1 = Console.ReadLine();
                } while (check(input1));

                do
                {
                    Console.WriteLine("Enter Value 2: ");
                    input2 = Console.ReadLine();
                } while (check(input2));

                do
                {
                    Console.WriteLine("(A)dd, (S)ubtract: ");
                    op = Console.ReadLine();
                    op = op.ToLower();
                } while (checkop(op));

                value1 = int.Parse(input1);
                value2 = int.Parse(input2);
                if (op == "a")
                {
                    result = add(value1, value2);
                    Console.WriteLine("The answer is: " + result);
                }
                else
                {
                    result = sub(value1, value2);
                    Console.WriteLine("The answer is: " + result);
                }
                Console.WriteLine("Do you want another go?(y/n) ");
                ans = Console.ReadLine();
                if (ans.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                
            } while (true);
            
        }

        static bool check(string value1)
        {
            int intFromString;
            if (int.TryParse(value1, out intFromString))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool checkop(string value1)
        {
            switch (value1)
            {
                case "a":
                    return false;
                case "s":
                    return false;
                default:
                    return true;
            }
        }
        static int add(int value1, int value2)
        {
            return value1 + value2;
        }
        static int sub(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
