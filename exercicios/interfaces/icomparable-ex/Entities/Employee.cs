using System;
using System.Collections.Generic;
using System.Globalization;

namespace icomparable_ex.Entities {
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] fields = csvEmployee.Split(",");
            Name = fields[0];
            Salary = double.Parse(fields[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            if (!(obj is Employee)) {
                throw new ArgumentException("Argumento não é um Employee");
            }

            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}