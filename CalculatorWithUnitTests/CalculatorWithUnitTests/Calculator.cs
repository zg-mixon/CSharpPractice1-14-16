using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithUnitTests
{
    public class Calculator
    {
        public double Add (params double[] nums) {
           double sum = 0;
            foreach (double num in nums) {
                sum += num;
            }
            return sum;
        }
        public double Subtract(double input1, double input2)
        {
            return input1 - input2;
        }
        public double Multiply(double input1, double input2)
        {
            return input1 * input2;
        }
        public double Divide(double input1, double input2)
        {
            return input1 / input2;
        }
        public double Exp(double b, double exp) {
            return Math.Pow(b, exp);
        }
    }
}
