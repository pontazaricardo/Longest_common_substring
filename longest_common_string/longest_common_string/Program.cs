using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_common_string
{
    class Program
    {
        static void Main(string[] args)
        {
            test_1();
            test_2();
            test_custom(new[] { "20010LEDMG WH RFR1", "20010LEDMG WH RFR2", "20110LEDMG WH 123" });

            Console.Read();
        }

        /// <summary>
        /// Test for common substring at the beginning of all the strings.
        /// </summary>
        static void test_1()
        {
            string[] str = new[] { "hab-a-b-c-h", "hab-a-b-c-d", "hab-a-b-cd-e", "hab-a-b-c-d" };
            string mostCommonSubstring = str.GetMostCommonSubstrings().FirstOrDefault();
            if (string.IsNullOrEmpty(mostCommonSubstring))
            {
                Console.Write("Empty");
            }

            Console.WriteLine("======= BEGIN TEST 1 =======");
            printArray(str);

            Console.WriteLine("Longest common string: " + mostCommonSubstring);
            Console.WriteLine("======= END TEST 1 =======\n");
        }

        /// <summary>
        /// Test for common substring at the end of all the strings.
        /// </summary>
        static void test_2()
        {
            string[] str = new[] { "20010LEDMG-WH/RFR", "20010MG-WH/RFR" };
            string mostCommonSubstring = str.GetMostCommonSubstrings().FirstOrDefault();
            if (string.IsNullOrEmpty(mostCommonSubstring))
            {
                Console.Write("Empty");
            }

            Console.WriteLine("======= BEGIN TEST 2 =======");
            printArray(str);

            Console.WriteLine("Longest common string: " + mostCommonSubstring);
            Console.WriteLine("======= END TEST 2 =======\n");
        }


        /// <summary>
        /// A customized test to look for the longest common substring in a list of strings.
        /// </summary>
        /// <param name="str"></param>
        static void test_custom(string[] str)
        {
            string mostCommonSubstring = str.GetMostCommonSubstrings().FirstOrDefault();
            if (string.IsNullOrEmpty(mostCommonSubstring))
            {
                Console.Write("Empty");
            }

            Console.WriteLine("======= BEGIN CUSTOM TEST =======");
            printArray(str);

            Console.WriteLine("Longest common string: " + mostCommonSubstring);
            Console.WriteLine("======= END CUSTOM TEST =======\n");
        }

        /// <summary>
        /// Prints a line to console with all the elements in the array (separated by commas)
        /// </summary>
        /// <param name="str"></param>
        static void printArray(string[] str)
        {
            Console.WriteLine("List of strings to test:");
            for (int i = 0; i < str.Count(); i++)
            {
                Console.Write(str[i]);
                if (i < str.Count() - 1)
                {
                    Console.Write(", "); //Comma after each string
                }
            }
            Console.WriteLine("");
        }
    }
}
