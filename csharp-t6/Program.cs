using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp_t6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
            };
        

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            if (cities.ContainsKey("UK"))
            {
                cities["UK"] = "US";
            }

            if (cities.ContainsKey("France")){ // check key before removing it
                cities.Remove("France");
            }

            //Hashtable
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities1 = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry de in cities1)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            Dictionary < int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);

            //Stack
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1, 

            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack1 = new Stack<int>(arr);

            foreach (var item in myStack1)
                Console.Write(item + ","); //prints 4,3,2,1

            //Queue
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id); //prints 1234

            //Tuple
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);


            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest); //8th pos for nested tuple
            Console.WriteLine(numbers.Rest.Item1);


            var numbers1 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers1.Item1);
            Console.WriteLine(numbers1.Item7);
            Console.WriteLine(numbers1.Rest.Item1);
            Console.WriteLine(numbers1.Rest.Item1.Item1);
            Console.WriteLine(numbers1.Rest.Item1.Item6);

            //Value tuple
            ValueTuple< int, string, string> person1 = (1, "Bill", "Gates");
            Console.WriteLine(person1.Item1);
            Console.WriteLine(person1.Item2);
            Console.WriteLine(person1.Item3);

            //shorter way
            (int, string, string) person2 = (1, "James", "Bond");

            (int id, string FirstName, string LastName) person3 = (1, "Bill", "Gates");
            Console.WriteLine(person3.FirstName);

            var person4 = (Id: 1, FirstName: "Bill", LastName: "Gates");

        }
    }
}
