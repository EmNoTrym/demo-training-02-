using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp_t5
{
    class Program
    {
        static void Main(string[] args)
        {
            //if, else if, else Statements

            int a = 10, b = 20;

            if (a != b)
            {
                if (a < b)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (a > b)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
                Console.WriteLine("i is equal to j");


            //for Loop
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }

            //while loop

            int j = 0;
            while (j < 100)
            {
                Console.WriteLine("j = {0}", j);

                j++;

                if (j > 10)
                    break;
            }

            //do while Loop
            do
            {
                Console.WriteLine("i = {0}", j);
                j++;

            } while (j < 5);

            //array
            int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };

            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var evenNums1 = new int[] { 2, 4, 6, 8, 10 };

            var cities1 = new string[] { "Mumbai", "London", "New York" };

            //Multidimensional Arrays

            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            Console.WriteLine(arr2d[0, 0]);
            Console.WriteLine(arr2d[0, 1]);
            Console.WriteLine(arr2d[1, 0]);
            Console.WriteLine(arr2d[1, 1]);
            Console.WriteLine(arr2d[2, 0]);
            Console.WriteLine(arr2d[2, 1]);



            //Jagged Arrays

            int[][] jArray = new int[2][]{
                new int[3]{1, 2, 3},

                new int[4]{4, 5, 6, 7}
            };

            Console.WriteLine(jArray[0][0]);
            Console.WriteLine(jArray[0][1]);
            Console.WriteLine(jArray[0][2]);
            Console.WriteLine(jArray[1][0]);
            Console.WriteLine(jArray[1][1]);
            Console.WriteLine(jArray[1][2]);
            Console.WriteLine(jArray[1][3]);

            //ArrayList

            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            

            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            primeNumbers.Insert(4, 12);
            primeNumbers.Remove(12);
            primeNumbers.RemoveAt(3);
            primeNumbers.Contains(7);

            //SortedList
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

            Console.WriteLine(numberNames[1]); //output: One
            Console.WriteLine(numberNames[2]); //output: Two
            Console.WriteLine(numberNames[3]); //output: Three
                                               //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            numberNames[2] = "TWO"; //updates value
            numberNames[4] = "Four"; //adds a new key-value if a key does not exists
        }
    }
}
