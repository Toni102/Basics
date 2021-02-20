using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvideo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arithmetic operators
            Console.WriteLine("================ Arithmetic operators");
            
            int? num1 = null;
            int num2;
            double rezultat;

            num1 = 4;
            num2 = 3;

            rezultat = Convert.ToDouble(num1 + num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1 - num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1 * num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, rezultat);
            rezultat = Convert.ToDouble(num1 % num2);
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rezultat);

            // Mathematical operators
            Console.WriteLine("================ Mathematical operators");

            num1 = 4;
            num2 = 3;
            bool rez;

            rez = num1 == num2;
            Console.WriteLine("{0} = {1} => {2}", num1, num2, rez);
            rez = num1 != num2;
            Console.WriteLine("{0} != {1} => {2}", num1, num2, rez);
            rez = num1 > num2;
            Console.WriteLine("{0} > {1} => {2}", num1, num2, rez);
            rez = num1 < num2;
            Console.WriteLine("{0} < {1} => {2}", num1, num2, rez);
            rez = num1 >= num2;
            Console.WriteLine("{0} >= {1} => {2}", num1, num2, rez);
            rez = num1 <= num2;
            Console.WriteLine("{0} <= {1} => {2}", num1, num2, rez);

            //Logical operators
            Console.WriteLine("================ Logical operators");

            bool val1, val2;

            val1 = true;
            val2 = false;

            rez = val1 && val2;
            Console.WriteLine("{0} AND {1} => {2}", val1, val2, rez);
            rez = val1 || val2;
            Console.WriteLine("{0} OR {1} => {2}", val1, val2, rez);
            rez = !(val1 || val2);
            Console.WriteLine("{0} OR {1} NOT => {2}", val1, val2, rez);

            // IF - USLOVI
            Console.WriteLine("================ IF");

            bool a1;
            a1 = false;
            int brojac = 10;
            if (brojac > 5)
            {
                Console.WriteLine("A1 je TRUE");
            }

            bool b1;
            b1 = false;
            int brojac1 = 10;
            if (brojac1 > 5)
            {
                Console.WriteLine("Brojac1 je veci od 5");
            }
            if (brojac1 < 5)
            {
                Console.WriteLine("Brojac1 je manje od 5");
            }

            bool b2;
            b2 = false;
            int brojac2 = 5;
            if (brojac2 > 5)
            {
                Console.WriteLine("Brojac2 je veci od 5");
            }
            else 
            { 

                Console.WriteLine("Brojac2 je manji ili jednak  5");
            }

            bool b3;
            b3 = false;
            int brojac3 = 5;

            if (brojac3 > 5)
            {
                Console.WriteLine("Brojac3 je veci od 5");
            }
            else if (brojac3 < 5)
            {
                Console.WriteLine("Brojac3 je manji od 5");
            }
            else
            {
                Console.WriteLine("Brojac3 je jednak 5");
            }


            int a = 101;
            int b = 201;

            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("Value of a = {0} and b = {1}", a, b);
                }
            }
            else
            {
                if (b < 100)
                {
                    Console.WriteLine("a is not 100, and b is {0}", b);
                }
                else
                {
                    Console.WriteLine("b is not less than 100");
                }
            }
            Console.WriteLine("Exact value of a is {0}", a);
            Console.WriteLine("Exact value of b is {0}", b);

            // Null coalescing
            Console.WriteLine("================ Null coalescing operator (??)");

            int? x = null;
            int? z = 100;
            int? rezab;

            rezab = x ?? z;
            Console.WriteLine("Vrednost rezab = {0}", rezab);

            // SWITCH
            Console.WriteLine("================ SWITCH");

            int s;
            s = 4;
            
            switch (s)
            {
                case 1:
                    Console.WriteLine("s = 3");
                    break;

                case 2:
                    Console.WriteLine("s = 2");
                    break;

                default:
                    Console.WriteLine("s = {0}", s);
                    break;
            }

            Console.WriteLine("================================================");

            // Constants
            const double PI = 3.14159;
            double r;

            Console.Write("Unesi radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double area = PI * r * r;
            Console.WriteLine("Radijus: {0}, povrsina: {1}", r, area);

            Console.ReadKey();
        }
    }
}

