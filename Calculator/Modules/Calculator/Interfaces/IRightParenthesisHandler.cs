using System.Collections;
using System.Collections.Generic;

namespace Calculator.Modules.Calculator.Interfaces
{
    public interface IRightParenthesisHandler
    {

        void AddItemsPostfixQueueRightParOperationWithoutFunction(Stack operatorStack,
            Queue<string> postfixQueue, ref int leftParenthesisNumber);


        void AddItemsPostfixQueueRightParOperationWithFunction(Stack operatorStack, Queue<string> postfixQueue,
            ref int functionsNumber, ref int leftParenthesisNumber);
    }
}
