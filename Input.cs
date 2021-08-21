using System;

namespace Rax.App.Cmd.Calci
{
    class Input
    {
        public static double ValidateNumber(string InfoMsg)
        {
            Console.Write("\n\t"+InfoMsg);
            double number=double.Parse(Console.ReadLine().Trim());

            return number;
        }
        public static int ValidateOperation(string InfoMsg)
        {
            
            Console.Write("\n\t"+InfoMsg);
            int number=int.Parse(Console.ReadLine().Trim());

            return number;
        }

        
       
    }
}