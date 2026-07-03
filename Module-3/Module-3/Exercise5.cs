using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Marks: ");

        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90)
            Console.WriteLine("Grade A");

        else if (marks >= 75)
            Console.WriteLine("Grade B");

        else if (marks >= 50)
            Console.WriteLine("Grade C");

        else
            Console.WriteLine("Fail");
    }
}