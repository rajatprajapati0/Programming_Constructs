using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;

namespace Conditional_statements
{
    internal class TypesOfStatements
    {
        public void IfElseStatements()
        {
            //1.Write a C# Sharp program to accept two integers and check whether they are equal or not.
            Console.WriteLine("program to accept two integers and check whether they are equal or not.");

            Console.WriteLine("enter  first integer  no. ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  second integer  no. ");
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum == secondNum)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("numbers are not equal\n");
            }


            //2.Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine(@"/////////Enter a integer number to check whether it is  even or odd\\\\\\\\\\\\\ ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even No.");
            }
            else
            {
                Console.WriteLine("Odd No.\n");
            }

            //3.Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his her own vote.

            Console.WriteLine(@"/////////program to read the age of a candidate and determine whether it is eligible for casting his her own vote.\\\\\\\\\\\\\\\\\\\");

            int eligibleAge = 18;
            Console.WriteLine("Enter candidate to check Eligiblilty");
            int candidateAge = int.Parse(Console.ReadLine());

            if (eligibleAge <= candidateAge)
            {
                Console.WriteLine("  candidate is eligible for casting his her own vote.");
            }
            else
            {
                Console.WriteLine("  candidate is not  eligible for casting his her own vote.");
            }

        }
        public void If_ElseIF_Else_Statements()
        {
            Console.WriteLine(@"/////////Enter three no. to get lragest number \\\\\\\\\\\\\ ");

            Console.WriteLine("enter number one");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number two");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number three");
            int num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("number one is largest");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("number two is largest");
            }
            else
            {
                Console.WriteLine("number three is largest");
            }


            Console.WriteLine(@"/////////find the eligibility for admission of a candidate\\\\\\\\\\\\\ ");


            Console.WriteLine("enter Marks in Maths ");
            int marksOfMath = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Marks in Physics");
            int marksOfPhysics = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Marks in Chemistry");
            int marksOfChemistry = int.Parse(Console.ReadLine());


            int allThreeSubject = marksOfMath + marksOfChemistry + marksOfPhysics;

            int marksOfPhysicsChemistry = marksOfChemistry + marksOfPhysics;



            if (marksOfMath >= 65 && marksOfPhysics >= 55 && marksOfChemistry >= 50)
            {
                if (allThreeSubject >= 180 || marksOfPhysicsChemistry >= 140)
                {
                    Console.WriteLine("The candidate is eligible for admission.");

                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission.");

                }

            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");

            }

        }

          public void SwitchCaseStatement()
          {
            // 1.Take user input has weekday number to calculate the weekday name:
               Console.WriteLine("Enter no. to check week day");
               int dayNumber =int.Parse(Console.ReadLine());


               switch (dayNumber) 
               {
                case 1:
                    Console.WriteLine("Monday"); 
                    break;
                case 2:
                    Console.WriteLine("Tuesday");

                    break;
                case 3:
                    Console.WriteLine("Wednesday");

                    break;
                case 4:
                    Console.WriteLine("Thursday");

                    break;
                case 5:
                    Console.WriteLine("Friday"); 

                    break;
                case 6:
                    Console.WriteLine("Saturday");

                    break;
                case 7:
                    Console.WriteLine("Sunday");

                    break;
                 default: Console.WriteLine("enter vailid number");
                    break;
               }

            //  2.Take 2 numbers has user inputs and perform arithmetic operations on it.
            //i.e Addition, Subtraction, Multiplication and Division using switch Case.


            
            
            
            Console.WriteLine("Enter two number and do math opretion");
            Console.WriteLine("enter option >\n+ >Addition,\n- > Subtraction,\n* > Multiplication,\n/ >Division ");
                Console.WriteLine("Enter no.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine( "Enter symbol");
            string str = Console.ReadLine();
            Console.WriteLine("Enter no.");
            int num2 = int.Parse(Console.ReadLine());

            char option = str[0];


              switch (option)
              {
                case '+':
                    Console.WriteLine(num1+num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);

                    break;
                case '*':
                    Console.WriteLine(num1 *num2);
                    break;
                case '/':
                    if (num1 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else 
                    {
                     Console.WriteLine("0/n is not possible");
                    }                                      
                    break;
                default: Console.WriteLine("enter vailid option"); 
                    break;

              }



          }
    }
}
