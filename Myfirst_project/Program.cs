using System;
class Test
{
    public static void Main(String[] args)
    {
        string name = "Momen";
        const int id = 1234556565;
        double salary = 1234.987;
        Boolean it_is = true;
        char c = 'M';

        int x = 12;
        int y = 22;
        int sum = x + y;


        Console.WriteLine("Hello World");
        Console.WriteLine(1234);
        Console.WriteLine("hey it's Momen here");

        Console.WriteLine(name);
        Console.WriteLine(id);
        Console.WriteLine(salary);
        Console.WriteLine(it_is);
        Console.WriteLine(c);

        //Sum
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("Here is the sum= " +(x + y));


        //----------------------------
        // User input 
        //----------------------------

        string studentName;
        int studentAge;

        Console.WriteLine("Enter your name here: ");
        studentName = Console.ReadLine();
        

        Console.WriteLine("Enter your age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("My name is " + studentName);
        Console.WriteLine("Your age is " + studentAge);


        Console.WriteLine("The ans of the equation is= " +(4 + 5 * 2));
    }
}