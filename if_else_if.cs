using System;
using System.Data;

public class IfElseIf {
    public static void Main(string [] args) {
        Console.WriteLine("Enter a number:");
        int marks=Convert.ToInt32(Console.ReadLine());
        if(marks<0 || marks>100) {
            Console.WriteLine("Invalid Number");
        }
        else if (marks<=90 && marks>=80) {
            Console.WriteLine("Grade A");
        }
        else if(marks<80 && marks>=70) {
            Console.WriteLine("Grade B");
        }

        else if (marks<70 && marks>=60) {
            Console.WriteLine("Grade C");
        }
        else if (marks<60 && marks>=50) {
            Console.WriteLine("Grade D");
        }

        else {
            Console.WriteLine("Fail");
        }
    }
}