using Calculator.ViewModels.MainWindow;
using System.Threading.Tasks;

namespace Calculator.Modules.Calculator.Interfaces
{
    public interface IBasicCalculatorHandler
    {
        CalculatorViewModel Model { get; set; }


        void NumberButtonOperation(object numberText);

        void BasicArithmeticOperatorButtonOperation(object arithmeticOperatorText);


        void AnsButtonOperation(object ansText);

        void EqualButtonOperation(object equalText);


        Task DelButtonOperation();


        Task AcButtonOperation();


        void LeftParButtonOperation(object leftParenthesisText);


        void RightParButtonOperation(object rightParenthesisText);


        void PowButtonOperation(object powFunctionText);


        Task SquareButtonOperation();


        void TrigonometricFunctionsButtonOperation(object trigonometricFunctionText);

        void ModButtonOperation(object modFunctionText);

        void LnLogButtonOperation(object paramData);

        void RootButtonOperation(object paramData);

        void EButtonOperation(object eFunctionText);

        void FactButtonOperation(object factFunctionText);

        Task PlusMinusButtonOperation();
    }
}
