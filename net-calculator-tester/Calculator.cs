using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    internal class Calculator
    {
        float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
