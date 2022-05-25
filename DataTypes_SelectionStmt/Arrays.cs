using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_SelectionStmt
{
    internal class Arrays
    {
        //public static void Main(string [] args)
        //{
            // Array Declaration
            // Array Initialization
            /*int a = 0;
            a = 10;
            //char[] marksArray = {'a','b','c','d','e'};
            int[] marks = new int[1000];//0-999
            marks[0] = 110;
            marks[1] = 120;
            marks[2] = 130;
            marks[3] = 140;
            marks[4] = 150;
            marks[999] = 900;

            marks[0] = 120;
            Console.WriteLine("Length of array : " + marks.Length);

            Console.WriteLine(marks[0]);// accessing 4th value in Array
            for(int i = 0; i < marks.Length; i++)// [0,4] =>0,1,2,3,4
            {
                if (marks[i] != 0)
                {
                    Console.Write("Array index : " + i + "\t\t");
                    Console.WriteLine("Array value at index : " + marks[i]);
                }
            }*/
            ///////////////////////////////////////////////////
            // Write a C# Program for finding an element from an Integer Array
            // Size = 10
            // Take input from User for finding a particular element in that Array
            // {1,2,3,4,5,6,7,8,9,0} : 4 => key is found in the array
            // 10 -> key is not found in the array

            /*int[] numbers = {11,23,45,3,4,5,78,1,2,55};
            int key1 = 0;
            int key2 = 0;
            Console.WriteLine("Enter two KEYs to find in the array");  
            key1 = Convert.ToInt32(Console.ReadLine());
            key2 = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            int check = 0;
            for(int i = 0; i < numbers.Length;i ++)//0-9 indexes
            {
                if(numbers[i] == key1 || numbers[i] == key2)// match the KEY with array value at that index
                {
                    check = check + 1;
                    
                    //Console.WriteLine("KEY is found in the array");
                    //found = true;
                    //break;
                }
               
            }// end of loop

            // if check = 1 : only one KEY is found
            // if check = 0: no value is found
            // if check is >=2 : both are found
            if (check >= 2)
            {
                Console.WriteLine("Both KEYS are found");
            }
            else if (check == 0)
            {
                Console.WriteLine("Neither key1 nor key 2 is found");
            }
            else if (check == 1)
            {
                Console.WriteLine("Only one KEY is found");
            }*/

        //}
    }
}
