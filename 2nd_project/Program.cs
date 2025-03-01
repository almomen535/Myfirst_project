using System;
namespace _2nd_project
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            double x,y,result;
            double radius, area;
            double pi = 3.1416;
            int number1 = 20,number2=10;


            // Operators ( assignment, relational, logical operators)
            number1 += 5;
            Console.WriteLine($"Number is = {number1}");
            Console.WriteLine(number1 > number2);

            number1 += 22;
            Console.WriteLine($"Number is = {number1}");
            Console.WriteLine(number1 > number2);







            // User Input:
            Console.Write("Base of the triangle: ");
            x =  Convert.ToDouble(Console.ReadLine());
          

            Console.Write("Height of the triangle: ");
            y = Convert.ToDouble(Console.ReadLine());


            //Area of a triangle:
             result = 0.5 * x * y;
            Console.WriteLine("Area of the Triangle is = "+ result);



            // Area of a Circle:

            Console.Write("Radios of the circle is: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = pi * radius * radius;
            Console.WriteLine("Area of the Circle is = " + area);



        }
    }
}
