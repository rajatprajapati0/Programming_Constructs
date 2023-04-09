using System;

namespace Conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional statements ");
            TypesOfStatements obj = new TypesOfStatements();

            bool check=true;
            while (check) 
            {
                Console.WriteLine("Option-> 1 -to check 'if else' Example\n" +
                    "Option-> 2 -to check 'if elseIf else' Example\n" +
                    "Option-> 3 -to check 'Switch Case Statement' Example\n");
                int option=int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:obj.IfElseStatements();
                        break;
                    case 2:obj.If_ElseIF_Else_Statements();
                        break;
                    case 3:obj.SwitchCaseStatement();
                        break;
                
                }
            
            }
        }
    }
}
