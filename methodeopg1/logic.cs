using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodeopg1
{
    class logic
    {
       
        public static float Multiply(float numberOne, float numberTwo) // method that resturns a float where numberone and numbertwo is multiplied
        {

            float multiplyresult = numberOne * numberTwo;
            return multiplyresult;
        }

        public static float Divided(float numberOne, float numberTwo) //method that returns a float with two numbers divivded 
        {
            float dividedResult = numberOne / numberTwo;
            

            return dividedResult;
        }
       
        
        public static double Power(double number1, double number2) //returns a number with the power of 
        {

            double powerOf = Math.Pow(number1, number2);
            return powerOf;

        }
        
        
       
        


    }
}
