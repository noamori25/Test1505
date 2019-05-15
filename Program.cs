using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r = new Rational(8, 7);
            Rational r1 = new Rational(9, 0);
            Rational r2 = new Rational(-3, 3);
            Console.WriteLine(r2);
            Console.WriteLine(r1);

            Rational r3 = new Rational(1, 2);
            Rational r4 = new Rational(1, 2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);

          Console.WriteLine(r3.GreaterThen(r4));
            Console.WriteLine(r3.Equals(r4));
            Console.WriteLine(r3 + r4);
            Console.WriteLine(r3 - r4);
            Console.WriteLine(r3 * r4);



        }
    }
}
