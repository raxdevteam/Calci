using System;
using System.Collections.Generic;
using System.Text;

namespace Rax.App.Cmd.Calci
{
    class info
    {
        public double firstnum;// access modifier
        //using properties to make accessible in other class

        public double Firstnum
        {
            get { return firstnum; }
            set { firstnum = value; }
        }

        public double method2()

        {
            Console.WriteLine("Enter first number: ");
            Firstnum = Double.Parse(Console.ReadLine());
            return Firstnum;
        }
    }
}