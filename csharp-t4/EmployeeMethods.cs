﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_t4
{
    public partial class Employee
    {
        //constructor
        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.EmpId + " ", this.Name);
        }
    }
}
