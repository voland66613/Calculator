using System.Collections;
using System.Collections.Generic;

namespace Calculator.Modules.Calculator.Interfaces
{
    public interface IBasicArithmeticOperatorHandler
    {

        void AddBasicArithmeticOperatorOperatorStack(Stack operatorStack, Queue<string> postfixQueue, string arithmeticOperator);
    }
}
