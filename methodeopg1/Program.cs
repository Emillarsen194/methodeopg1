using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodeopg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast dit første tal");
            float numberOne = float.Parse(Console.ReadLine());
            Console.WriteLine("indtast dit andet tal");
            float numberTwo = float.Parse(Console.ReadLine());
         
            Console.WriteLine(numberOne + " gange med " + numberTwo + " = " + logic.Multiply(numberOne, numberTwo)); //multiply method
            Console.WriteLine(numberOne + " divideret med " + numberTwo + " = " + logic.Divided(numberOne, numberTwo)); //division method
            Console.WriteLine(numberOne + " opløftede med " + numberTwo + " = " + logic.Power(numberOne, numberTwo)); //powerof method

            Console.ReadKey();
                        
        }
       
       
    }
}
