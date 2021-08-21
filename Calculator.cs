using System;

namespace Rax.App.Cmd.Calci
{
    class Calculator
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Mul(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Div(double n1, double n2)
        {
            return n1 / n2;
        }


        public static double Square(double n)
        {
            return n*n;
        }

        public static long Factorial(int n)
        {
            long fact=1;
            if(n==0) 
                return 1;
            while(n>1)
            {
                fact*=n;
                n--;
            }
            return fact;
        }
    

        public static double Power(double b, int i)
        {
            double p=1;
            if(i==0 && b>0) 
                return 1;
            if(i==0 && b==0)
                return double.NaN;
            while(i>0)
            {
                p*=b;
                i--;
            }
            return p;
        }
    }

}