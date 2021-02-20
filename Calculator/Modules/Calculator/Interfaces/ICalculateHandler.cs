using System.Collections;
using System.Collections.Generic;

namespace Calculator.Modules.Calculator.Interfaces
{
    public interface ICalculateHandler

        string Calculate(Stack operatorStack, Queue<string> postfixQueue, 
            double functionMultiplier, ref double ansValue);
    }
}
