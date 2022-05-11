using System;
using System.Collections.Generic;

namespace csharp_t4
{
    class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;

            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student std2)
        {
            std2.name = "Steven";
        }

        public static class Calculator
        {
            private static int _resultStorage = 0;

            public static string Type = "Arithmetic";

            public static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            public static void Store(int result)
            {
                _resultStorage = result;
            }
        }

        static void Main(string[] args)
        {
            //anonymous_type
            var student = new {
                Id = 1, 
                FirstName = "James", 
                LastName = "Bond", 
                Age = 17,
                Address = new { Id = 1, City = "London", Country = "UK" }
            };

            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Address.City);
            Console.WriteLine(student.Address.Country);

            //dynamic_type
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Im string!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = new StringBuild();
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar.print(), MyDynamicVar.GetType());

            //Nullable type
            //Nullable<int> i = null;
            Nullable<int> i = 69;

            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");

            //Value Type and Reference Type
            //Passing Value Type Variables
            int ii = 100;

            Console.WriteLine(ii);

            ChangeValue(ii); //it wouldn't affect the variable in another method

            Console.WriteLine(ii);

            //Reference Type
            Student std1 = new Student();
            std1.name = "Billy";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.name);

            //Interface
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            IBinaryFile file3 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            //error
            //file2.ReadFile();
            //file2.WriteFile("content");

            file3.ReadFile();
            file3.OpenBinaryFile();

            //Operators
            int x = 5 + 5;
            int y = 10 + x;
            int z = x + y;

            //partial-class: The compiler will combine all the implementation from multiple .cs files when the program is compiled
            var emp = new Employee(1, "John");
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.Name);

            emp.DisplayEmpInfo();

            //Static Class
            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable

            //Object Initializer Syntax
            var student1 = new Student() { id = 1, name = "John" };
            var student2 = new Student() { id = 2, name = "Steve" };
            var student3 = new Student() { id = 3, name = "Bill" };
            

            IList<Student> studentList = new List<Student>() {
                                                    student1,
                                                    student2,
                                                    student3,
                                                    
                                                };
            Console.WriteLine(studentList[1].name);
        }
    }
}
