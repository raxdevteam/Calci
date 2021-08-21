using System;

namespace Rax.App.Cmd.Calci
{
    class Menu
    {
        double n1, n2, result;

        string[] operationName=new string[]{"Addition",
                                            "Subtraction",
                                            "Multiplication",
                                            "Division",
                                            "Square",
                                            "Factorial"
                                            };
        
        public Menu()
        {
        }
        public void DisplayContent()

        {
            Console.WriteLine("\t+----------------------------+");
            Console.WriteLine("\t|         RAX CALCI          |");
            Console.WriteLine("\t+----------------------------+");
            Console.WriteLine("\t|  1. Addition               |");
            Console.WriteLine("\t|  2. Subtraction            |");
            Console.WriteLine("\t|  3. Multiplication         |");
            Console.WriteLine("\t|  4. Division               |");
            Console.WriteLine("\t|  5. Square                 |");
            Console.WriteLine("\t|  6. Factorial              |");
            Console.WriteLine("\t|  7. Clear                  |");
            Console.WriteLine("\t|  8. Exit                   |");
            Console.WriteLine("\t+----------------------------+");
          
            int number=Input.ValidateOperation("Enter option to proceed : ");
            Operation(number);
        }

        private void DisplayResult(int opType, double result)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t------------------------------------");
            Console.WriteLine("\t"+operationName[opType]+" : "+ result);
            Console.WriteLine("\t------------------------------------");           
            Console.Write("\n\tPress Enter key for other operation_|");
            Console.ReadKey();
            Console.WriteLine("\n");
            DisplayContent();
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public void Operation(int operationType)
        {
            switch(operationType)
            {
                case 1 : n1=Input.ValidateNumber("Enter first number : ");
                         n2=Input.ValidateNumber("Enter second number : ");
                         result=Calculator.Add(n1, n2);
                         DisplayResult(operationType-1, result);
                         break;
                case 2 : n1=Input.ValidateNumber("Enter first number : ");
                         n2=Input.ValidateNumber("Enter second number : ");
                         result=Calculator.Sub(n1, n2);
                         DisplayResult(operationType-1, result);
                         break;
                case 3 : n1=Input.ValidateNumber("Enter first number : ");
                         n2=Input.ValidateNumber("Enter second number : ");
                         result=Calculator.Mul(n1, n2);
                         DisplayResult(operationType-1, result);
                         break;
                case 4 : n1=Input.ValidateNumber("Enter first number : ");
                         n2=Input.ValidateNumber("Enter second number : ");
                         result=Calculator.Div(n1, n2);
                         DisplayResult(operationType-1, result);
                         break;  
                case 5 : n1=Input.ValidateNumber("Enter a number : ");
                         result=Calculator.Square(n1);
                         DisplayResult(operationType-1, result);
                         break; 
                case 6 : n1=Input.ValidateNumber("Enter a number : ");
                         result=Calculator.Factorial((int)n1);
                         DisplayResult(operationType-1, result);
                         break;
                case 7 : ClearScreen();DisplayContent();break;
                case 8 : break;         
                default: Console.WriteLine("\t\n\nOppsss...Invalid operation\n");
                         DisplayContent();break;                     
            }
        }

        
    }
}