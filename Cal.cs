using System;
using System.Collections.Generic;
using System.Text;

namespace Rax.App.Cmd.Calci
{

class Cal

    {
        public double answer;

        info num1 = new info();
        temp num2 = new temp();

        public void add()

        {
            answer = (num1.method2() + num2.method3());
            Console.WriteLine("ANSWER");
            Console.WriteLine(+answer);
        }
        public void subtract()

        {
            answer = (num1.method2() - num2.method3());
            Console.WriteLine("ANSWER");
            Console.WriteLine(+answer);
        }
        public void multiply()

        {
            answer = (num1.method2() * num2.method3());
            Console.WriteLine("ANSWER: ");
            Console.WriteLine(+answer);
        }
        public void divide()

        {
            answer = (num1.method2() / num2.method3());
            Console.WriteLine("ANSWER");
            Console.WriteLine(+answer);
        }
        public void remainder()

        {
            answer = (num1.method2() % num2.method3());
            Console.WriteLine("ANSWER");
            Console.WriteLine(+answer);
        }
    }
}