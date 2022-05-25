using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_SelectionStmt
{
    internal class ArrayPractice
    {
        public static void Main(string [] args)
        {

            // C# Program: => ABBA <= : Palindrome
            /*Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string reverse = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                reverse = reverse + str[i].ToString();// converting char to string
            }
            Console.WriteLine("This is a Reverse string : "+ reverse);
            if (reverse == str)
                Console.WriteLine("String is a Plindrome");
            else
                Console.WriteLine("Not Palindrome");
            
            */

            // 2D Arrays : Maze, Tic-Tac-Toe, Mine-Craft
            int[,] table = new int[3, 2];// row are 3, columns are 2
            // first row
            table[0, 0] = 1;
            table[0, 1] = 1;
            // second row
            table[1, 0] = 2;
            table[1, 1] = 2;
            // third row
            table[2, 0] = 3;
            table[2, 1] = 3;
            int[,] table2 = { {1,1 }, {2,2 }, {3,3 } };

            // Take input from User in 2D Array
            for(int i = 0; i < 3; i++) // rows
            {
                for(int j = 0; j < 2; j++)
                {
                    // Convert.toInt32()
                    table[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Print values from 2D Array
            for (int i = 0; i < 3; i++) // rows
            {
                Console.Write("   " + "[");
                for (int j = 0; j < 2; j++)
                {
                   Console.Write (table[i, j] + "    ");
                }
                Console.Write("]");
                Console.WriteLine();
            }




        }
    }
}
