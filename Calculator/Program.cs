using System.Dynamic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            while (true)
            {
                PerformOneCalculation();
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator!");
        }

        private static void PerformOneCalculation()
        {
            string[] validInputs = { "+" , "*" , "/" , "-"};
            Console.WriteLine("Enter the operator:");
            string operatorInput = Console.ReadLine();
            int operatorIndex = Array.IndexOf(validInputs,operatorInput);
            if(operatorIndex>=0)
            {
                Console.WriteLine("How many numbers would you like to "+validInputs[operatorIndex]+" ?");
                string numOfNumsInput = Console.ReadLine();
                int numOfNums = int.Parse(numOfNumsInput);
                double[] nums = new double[numOfNums];
                double result = NumberInput(1);
                nums[0] = result;
                for (int currentNum = 1; currentNum < numOfNums; currentNum++)
                {
                    double numInput = NumberInput(currentNum+1);
                    nums[currentNum] = numInput;
                    switch (operatorIndex)
                    {
                        case 0:
                            result += numInput;
                            break;
                        case 1:
                            result *= numInput;
                            break;
                        case 2:
                            result /= numInput;
                            break;
                        case 3:
                            result -= numInput;
                            break;
                    }

                }
                
                string strResult = result.ToString();
                Console.WriteLine("The answer is: "+strResult);
            }
            else
            {
                Console.WriteLine("Please enter a valid operator (+,-,*,/)");
            }
        }

        private static double NumberInput(int number)
        {
            Console.WriteLine("Enter number "+number+":");
            string numInput = Console.ReadLine();
            double numOutput;
            while (true)
            {
                if (double.TryParse(numInput, out numOutput))
                {
                    return numOutput;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please re-enter number "+number+":");
                    numInput = Console.ReadLine();
                }
            }
        }
    }
}