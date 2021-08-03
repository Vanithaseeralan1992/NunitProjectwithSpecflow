using System;
using System.Collections.Generic;
using System.Text;

namespace NunitProject.Pages
{   public class Calculator
    {

        public int firstnumber { get; set; }
        public int secondnumber { get; set; }

        public int Add()
        {
            return firstnumber + secondnumber;
        }

        public int Subtract()
        {
            return firstnumber - secondnumber;
        }

    }

    public class EmployeeDetails
    {
        public string Name { get; set; }
        public Int64 Phone { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
