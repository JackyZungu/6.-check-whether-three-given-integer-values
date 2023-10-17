using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.check_whether_three_given_integer_values
{
    public class Program
    {
        public static bool Check(int num1, int num2, int num3)
        {
            return (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50);
        }

        public static void Main(string[] args)
        {
            int[] input1 = { 11, 30, 25, 15 };
            int[] input2 = { 20, 30, 35, 12 };
            int[] input3 = { 12, 17, 50, 8 };

            for (int i = 0; i < input1.Length; i++)
            {
                bool result = Check(input1[i], input2[i], input3[i]);
                Console.WriteLine($"{input1[i]}, {input2[i]}, {input3[i]} -> {result}");
            }
        }
    }

}
