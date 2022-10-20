// See https://aka.ms/new-console-template for more information
using System;

/*

Sweet ‘n Salty .NET console application 
Summary: 
The Sweet and Salty Console Application prints numbers to 
the console screen starting 
at a number specified by the user and stopping at a 
number specified by the user. 

 The range of the two numbers is limited to 1000.  
The quantity of numbers printed per line is also decided by the user with a maximum of 30.
 The application will print “Sweet” instead of any number that is a multiple of 3. 
The application will print “Salty” instead of any number that is a multiple of 5. 
The application will print “Sweet’nSalty” instead of any number that is a multiple of both 3 and 5. 
The application prints a summary after completing the printout. 

Requirements to be graded:  Due Thursday, 10.20.22, 5pm.  
[x]Create a new repo for yourself in the batch org called fname-lname-challenges.
[x]Clone this new repo and create a new branch called, CodeAssignment-fname-lname (ex. CodeAssignment-mark-moore)   
[x]Create for your source code a directory titled, SweetSaltyChallenge Create a new .NET C# console application   
[x]Get the start and stop numbers (within the 1000 range) from the user. 
[x]You must re-prompt if the difference between the numbers is more than 1000. 
[x]If the numbers are given in the wrong order, re-prompt. (ex. first number 1000, second number 100.)
[x]Get the quantity of numbers you will print on each line from the user. 
[x]You must re-prompt if the quantity chosen by the user is greater than 30 or less than 5 
[]Print the numbers in groups of what the user says per line with one space separating each number. 
[]If the number is a multiple of three, print “Sweet” (instead of the number) to the console.     
[]If the number is a multiple of five, print “Salty” (instead of the number) to the console.     
[]For numbers which are multiples of both three and five, print “Sweet’nSalty” to the console (instead of the number).     
[]After the numbers have all been printed to the console, print to the console on 3 separate lines, how many "Sweet",  
[]how many "Salty", and  how many "Sweet’nSalty" numbers there were.  'Sweet', 'Salty', and 'Sweet'nSalty' are three 
[]separate groups, so "Sweet’nSalty" does not increment "Sweet" or "Salty" (and vice versa).    
[]Include verbose commentary in the source code to tell me what each few lines are doing. 
[]Make sure to merge this branch to your main branch, by 5pm today. 
 

*/


public class SweetNSalty
{

    static int startNum; //variable for the starting number
    static int endNum; //variable for the ending number
    static int quantity;

    public static void Main()
    {

        System.Console.WriteLine("Sweet and salty Challenge");
        tryAgain();
        howMany();
        

    }

    public static void tryAgain() //Prompts users to enter a starting and ending number
    {

        Console.WriteLine("Please enter a number to start with:");
        startNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a number to stop at:");
        endNum = Convert.ToInt32(Console.ReadLine());
        numRange();
        numOrder();


    }

    public static void howMany()//To collect quantity of numbers user wants printed
    {
        System.Console.WriteLine($"How many numbers from this range {startNum}-{endNum} would you like printed?");
        System.Console.WriteLine("--It must be more than 5 but less than 30.--");
        quantity = Convert.ToInt32(Console.ReadLine());

        if (quantity > 30 || quantity < 5)
        {
            System.Console.WriteLine("Try again!");
            howMany();
        } else if(quantity > endNum || quantity < startNum){
             System.Console.WriteLine("Try again!");
            howMany();
            
        }else {
            printNums();
        }
    }

    public static void numRange()//limiting range
    {
        int max = startNum + 1000;

        if (endNum > max)
        {
            System.Console.WriteLine("Your starting and ending numbers can only be 1000 apart!");
            tryAgain();
        }

    }
    public static void numOrder() //checks if ending number is less than the starting number
    {
        if (endNum < startNum)
        {
            System.Console.WriteLine("The ending number should be less than the starting number!");
            tryAgain();
        }
    }

    public static void printNums()
    {
        IEnumerable<int> userRange = Enumerable.Range(startNum, endNum);

        foreach (int r in userRange)
        {
            System.Console.WriteLine(r);
        }

    }



}


