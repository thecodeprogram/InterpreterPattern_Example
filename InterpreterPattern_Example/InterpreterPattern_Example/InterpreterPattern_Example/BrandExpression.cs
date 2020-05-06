/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 06.05.2020
*/

using System;

namespace InterpreterPattern_Example
{
    class BrandExpression : Expression
    {
        public void InterpretContext(Context context)
        {
            if (context.getIsAircraft() == true)
            {
                if (context.getFirstChar().Equals("A"))
                    Console.WriteLine("Brand is Airbus");
                else if (context.getFirstChar().Equals("B"))
                    Console.WriteLine("Brand is Boeing");
            }
            else
                Console.WriteLine("Brand could not be interpreted");
        }
    }
}
