using System;

class GotoStatement {
    static void Main(string[] args) {
        Ineligible:
            Console.WriteLine("You are not eligible to vote");
        Console.WriteLine("Enter your age:");
        int age=Convert.ToInt32(Console.ReadLine());

        if (age<18) {
            goto Ineligible;

        }
        else {
            Console.WriteLine("You are eligible to vote");
        }

        
    }
}