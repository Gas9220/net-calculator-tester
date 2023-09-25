using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    static public class Calculator
    {
        static public float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        static public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        static public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        static public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
