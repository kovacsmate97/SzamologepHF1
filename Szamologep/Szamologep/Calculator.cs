using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Calculator
    {
        public static double Osszead(double x, double y)
        {
            return x + y;
        }
        public static double Kivon(double x, double y)
        {
            return x - y;
        }
        public static double Szorzas(double x, double y)
        {
            return x * y;
        }
        public static double Osztas(double x, double y)
        {
            return x / y;
        }
        public static void CE(double y)
        {
            y = 0;
            return;
        }
        public static void C(double x, double y)
        {
            x = 0;
            y = 0;
            return;

        }
    }
}