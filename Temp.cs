using System;
using System.Collections.Generic;
using System.Text;

namespace Rax.App.Cmd.Calci
{
class temp
   
    {
        public double secondnum; // access modifier
        //using properties to make accessible in other class
        public double Secondnum
        {
            get { return secondnum; }
            set { secondnum = value; }
        }

        public double method3()

        {
            Console.WriteLine("Enter Second number: ");
            Secondnum = Double.Parse(Console.ReadLine());
            return Secondnum;
        }
    }
}