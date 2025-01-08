using System.ComponentModel;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then,write a C# program to display the details of all the persons in the array.
            //// Create and populate an array of Person objects
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Ali", 30);
            //persons[1] = new Person("Haneen", 25);
            //persons[2] = new Person("Amira", 35);

            //// Display the details of all persons in the array
            //foreach (Person person in persons)
            //{
            //    person.DisplayInfo();
            //}
            #endregion

            #region Q2. Create a struct called "Point" to represent a 2D point with properties "X" and "Y".Write a C# program that takes two points as input from the user and calculates the distance between them.
            #region Solution1
            //// Input first point
            //Console.Write("Enter X for Point 1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Y for Point 1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Point point1 = new Point(x1, y1);

            //// Input second point
            //Console.Write("Enter X for Point 2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Y for Point 2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Point point2 = new Point(x2, y2);

            //// Calculate and display the distance
            //double distance = Point.CalculateDistance(point1, point2);
            ////Fixed-point format, which is a numeric format that displays a fixed number of decimal places.
            //Console.WriteLine($"The distance between the two points is: {distance:F2} cm"); 
            #endregion

            #region Solution2
            //// Another Soution 
            //Console.WriteLine("Enter coordinates for the points (X and Y):");
            //bool isparsed1;
            //bool isparsed2;
            //bool flag1;
            //bool flag2;
            //double x1;
            //double y1;
            //double x2;
            //double y2;
            //Point point1;
            //Point point2;
            //do
            //{
            //    Console.Write("Enter X for Point 1: ");
            //    isparsed1 = double.TryParse(Console.ReadLine(), out x1);
            //    if (!isparsed1)
            //    {
            //        Console.WriteLine("Invalid coordinate for the Point. Please enter a valid positive integer.");
            //    }
            //}
            //while (!isparsed1);

            //do
            //{
            //    Console.Write("Enter Y for Point 1: ");
            //    isparsed2 = double.TryParse(Console.ReadLine(), out y1);
            //    if (!isparsed2)
            //    {
            //        Console.WriteLine("Invalid coordinate for the Point. Please enter a valid positive integer.");
            //    }
            //}
            //while (!isparsed2);

            //point1 = new Point(x1, y1);

            //do
            //{
            //    Console.Write("Enter X for Point 2: ");
            //    flag1 = double.TryParse(Console.ReadLine(), out x2);
            //    if (!flag1)
            //    {
            //        Console.WriteLine("Invalid coordinate for the Point. Please enter a valid positive integer.");
            //    }
            //}
            //while (!flag1);

            //do
            //{
            //    Console.Write("Enter Y for Point 2: ");
            //    flag2 = double.TryParse(Console.ReadLine(), out y2);
            //    if (!flag2)
            //    {
            //        Console.WriteLine("Invalid coordinate for the Point. Please enter a valid positive integer.");
            //    }
            //}
            //while (!flag2);

            //point2 = new Point(x2, y2);

            //// Calculate and display the distance
            //double distance = Point.CalculateDistance(point1, point2);
            ////Fixed-point format, which is a numeric format that displays a fixed number of decimal places.
            //Console.WriteLine($"The distance between the two points is: {distance:F2} cm"); 
            #endregion

            #endregion

            #region Q3. Create a struct called "Person" with properties "Name" and "Age".Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];

            //// Input details for three persons
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:.........");

            //    Console.Write($"Enter Name for Person {i + 1}: ");
            //    string name = Console.ReadLine();
            //    bool isparsed;
            //    int age;
            //    do
            //    {
            //        Console.Write($"Enter Age for Person {i + 1}: ");
            //        isparsed = int.TryParse(Console.ReadLine(), out age) && age > 0;
            //        if (!isparsed)
            //        {
            //            Console.WriteLine("Invalid age. Please enter a valid positive integer.");
            //        }
            //    }
            //    while (!isparsed);

            //    persons[i] = new Person(name, age);
            //}
            //// Find the oldest person
            //Person oldest = persons[0];
            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldest.Age)
            //    {
            //        oldest = persons[i];
            //    }
            //}
            //// Display the oldest person's details
            //Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");

            #endregion

            #region Q4. 4.Create a struct named Rectangle that represents a rectangle with the following fields: width(type: double) , height(type: double)
            /*
             *=Implement encapsulation by making the fields private and provide
                public properties access and modify these values. Ensure the
                following conditions are met:
                The width and height should not be negative. If a negative value is
                provided, the setter should not update the field and should instead
                print an error message.
             *=Implement a public read-only property Area that calculates and
                 returns the area of the rectangle (Area = width * height).
                 Implement a method DisplayInfo that prints the rectangle's
                 dimensions and area.
             *=Write a program to demonstrate the usage of this struct by creating
                 an instance, setting values via properties, and displaying the area
             */

            //// Create a Rectangle instance
            //Rectangle rect = new Rectangle();

            //// Setting valid values for width and height
            //rect.Width = 10;   // Sets width to 10
            //rect.Height = 5;   // Sets height to 5

            //// Attempting to set negative values (will trigger error messages)
            //rect.Width = -4;   // Error: Width cannot be negative
            //rect.Height = -7;  // Error: Height cannot be negative

            //// Display rectangle's information
            //rect.DisplayInfo(); // Outputs the width, height, and calculated area

            #endregion
        }
    }
}
