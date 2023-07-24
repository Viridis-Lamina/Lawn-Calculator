using System;
using System.ComponentModel.DataAnnotations;

namespace Lawncalculator 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise - Write a program for a lawnmowing service. The lawn- mowing session lasts 20 weeks
            // * There are 3 different price ranges defined by the size of a lawn. if the lawn is under 400 square ft then it is £25
            // *  If it is is more than 400 square ft but less than 600 then its £35.
            // * if it is 600 or more then it is £50. This program needs to work out and display the cost for a 20 week session for the user. 



            // establishing cost variables
            double Lowprice = 25;
            double mediumprice = 35;
            double highprice = 50;

            // working out the size of the lawn in square ft.

         
            
            double cost;

            Console.WriteLine("Hello! thank you for choosing our Lawn mowing service please place in the dimensions of your lawn.");
            Console.WriteLine();
            Console.WriteLine("Please input the length of your lawn in ft");
            double Length= double.Parse(Console.ReadLine());

            Console.WriteLine("Perfect the length of your lawn is {0}", Length);
            Console.WriteLine();
            Console.WriteLine("Can you input the Width of the lawn?");

            double width= double.Parse(Console.ReadLine());
            Console.WriteLine("Ok so the Perfect the length of your lawn is {0} and the width of your lawn is {1}", Length, width);
            Console.WriteLine();
            Console.WriteLine("Let me just work this out");
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);

            Double area = Length * width;

            if (area < 400)
            {
                cost = Lowprice * 20;
                Console.WriteLine ("The area of your lawn is {0}",area) ;
                Console.WriteLine("So the cost for this sevice is £{0}", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for using our service we will be in touch");
            } 
            else if (area > 400 & area < 600)
            {
                cost = mediumprice * 20;
                Console.WriteLine(" The area of your lawn is {0}", area);
                Console.WriteLine("So the cost for this sevice is £{0}", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for using our service we will be in touch");

            }
            else { 
                cost = highprice * 20;
                Console.WriteLine(" The area of your lawn is {0}", area);
                Console.WriteLine("So the cost for this sevice is £{0}", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for using our service we will be in touch");

            }








        }
    }
}