using System;
using System.Reflection.PortableExecutable;

namespace comp100_test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 1:");
            Console.WriteLine("-----------");
            Exercise1();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("-----------");
            Exercise2();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 3:");
            Console.WriteLine("-----------");
            Exercise3();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 4:");
            Console.WriteLine("-----------");
            Exercise4();

            Console.WriteLine();
            Console.WriteLine("--- DONE!");
            Console.ReadKey();
        }

        static void Exercise1()
        { //Write a program to produce a table of numbers from 10 to 1, with their squares and cubes. Your table
          //must look professional, which means it should have a header and the columns should be right aligned. 

            // input
            int counter; 
            int square = 1;
            int cube = 1;
            const int value = 1;

            // PROCESSING
            Console.WriteLine("Number\t Square\t   Cube"); //setting up table
            Console.WriteLine("--------------------------");
            // OUTPUT

            for (counter = 10; counter >= value; counter--) //counter starts at 10 question states from 10 to 1, as long as counter is greater than or equal to 1 contiunes loop
            { // next counter = counter - 1 
                square = counter * counter; //calculate square, number times itself
                cube = square * counter; //calcualte cube, number times itself 3 times, shortcut use square and times the number again
                Console.WriteLine($"{counter,3}{square,10}{cube,10}"); //writes the table, starts with 10 and outputs square and cube, repeats till 1
            }
        }

        static void Exercise2()
        {
            // INPUT
            int year = 1;
            double deposit = 2000, rate = 0.09, interest = 0, balance = 0;


            // PROCESSING
            Console.WriteLine("Year\tBalance");
            Console.WriteLine("--------------");

            // OUTPUT
            while (year <= 10) //while year is less than or equal to 10 loop goes on
            {
                interest = deposit * rate; // interest is deposit * the interest rate
                balance = deposit + interest; // total balance is the amount in bank plus the interest for that year
                deposit = balance; //replace deposit with the nbew balance, so next loop deposit is updated to the new amount.
                Console.WriteLine($"{year,3}" + "\t" + balance.ToString("C")); //writes year, and converts balance to currency to display.
                year++; //increase the year by one, and repeat
            }
        }

        static void Exercise3()
        {
            // INPUT
            double grade, average = 0, sum = 0, counter = 0; ;
            // PROCESSING
            do
            {
                Console.Write("Enter a Grade (enter 999 to exit):"); //Ask user for grade
                grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 0 && grade <= 100) //if grade is greater than or equal to 0 and less than and equal to 100, it will enter this if statement
                {
                    sum = grade + sum; //add value of grade to operration
                    counter++; //up the counter for the loop
                }
                else if (grade == 999) //if grade is 999 breaks the loop
                    break;

                else //otherwise the grade is invalid and asked to try again
                {
                    Console.WriteLine("Invalid Grade, Please try again.");
                }
            } while (grade != 999); // ran into problem where entering 999 makes console write please try again. Put a break in loop and it never wrote that line for 999
            average = sum / counter;
            Console.WriteLine($"The sum of valid grades is: {sum}\nThe number of valid grades is: {counter}\nThe average of the valid grades is: {average}");
        }


            static void Exercise4()
            {
            // INPUT
            const int CODY_CONSTANT = 7;
            double x, y;
            Console.WriteLine("y= 2x^2 - x - 7");
            // PROCESSING
            Console.WriteLine("---------------------------------------------"); // start of chart
            Console.WriteLine("x\t2x^2\t-x\t-7\ty\t(x,y)");
            Console.WriteLine("---------------------------------------------");
            for (x = 1; x <= 5; x += 0.5) //for x from 1 to 5 and increasing by 0.5 each loop it will compute the following for y
            {
                y = (2 * x * x) - x - CODY_CONSTANT;
                Console.WriteLine($"{x:F1}\t{2 * x * x:F1}\t-{x:F1}\t-{CODY_CONSTANT}\t{y}\t({x},{y})"); // write x, 2*x^2,-x,-7,(x,y) 
                
            }

            // OUTPUT

        }

        }
    }