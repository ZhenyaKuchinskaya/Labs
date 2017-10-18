using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnit
{
    class Calculator
    {
        public static int Test_one(int first, int second)
        {
            return first + second;
        }

        public static int Test_two(int first, int second)
        {
            return first - second;
        }

        public static int Test_free(int first, int second)
        {
            return first / second;
        }

        public static int Test_four(int first, int second)
        {
            return first * second;
        }
}
}
