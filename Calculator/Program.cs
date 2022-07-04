using System.Dynamic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] validInputs = { "+" , "*" , "/" , "-"};
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Enter the operator:");
            string operatorInput = Console.ReadLine();
            int operatorIndex = Array.IndexOf(validInputs,operatorInput);
            if(operatorIndex>=0)
            {
                Console.WriteLine("Enter first number:");
                string numOneInput = Console.ReadLine();
                Console.WriteLine("Enter second number:");
                string numTwoInput = Console.ReadLine();
                double numOne = double.Parse(numOneInput);
                double numTwo = double.Parse(numTwoInput);
                double result = 0;
                switch (operatorIndex)
                {
                    case 0:
                        result = numOne + numTwo;
                        break;
                    case 1:
                        result = numOne * numTwo;
                        break;
                    case 2:
                        result = numOne / numTwo;
                        break;
                    case 3:
                        result = numOne - numTwo;
                        break;
                }
                string strResult = result.ToString();
                Console.WriteLine(numOneInput+" "+validInputs[operatorIndex]+" "+numTwoInput+" = "+strResult);
            }
            else
            {
                Console.WriteLine("Please enter a valid operator (+,-,*,/)");
            }
        }
    }
}