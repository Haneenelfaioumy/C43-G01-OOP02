using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal struct Person
    {
        #region Attributes
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} , Age: {Age}");
        } 
        #endregion

    }
}
