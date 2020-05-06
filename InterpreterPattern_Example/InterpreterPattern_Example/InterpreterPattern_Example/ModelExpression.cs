/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 06.05.2020
*/

using System;

namespace InterpreterPattern_Example
{
    class ModelExpression : Expression
    {
        public void InterpretContext(Context context)
        {
            if (context.getIsAircraft() == true)
            {
                Console.WriteLine("Model is : " + context.getModel().Substring(1, 3));
            }
            else
                Console.WriteLine("Model could not be interpreted");
        }
    }
}
