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
                Console.WriteLine("How many numbers would you like to "+validInputs[operatorIndex]+" ?");
                string numOfNumsInput = Console.ReadLine();
                int numOfNums = int.Parse(numOfNumsInput);
                double[] nums = new double[numOfNums];
                Console.WriteLine("Enter number 1:");
                string firstNum = Console.ReadLine();
                double result = double.Parse(firstNum);
                nums[0] = result;
                for (int currentNum = 1; currentNum < numOfNums; currentNum++)
                {
                    Console.WriteLine("Enter number "+(currentNum+1)+":");
                    string numInput = Console.ReadLine();
                    nums[currentNum] = double.Parse(numInput);
                    
                    switch (operatorIndex)
                    {
                        case 0:
                            result += double.Parse(numInput);
                            break;
                        case 1:
                            result *= double.Parse(numInput);
                            break;
                        case 2:
                            result /= double.Parse(numInput);
                            break;
                        case 3:
                            result -= double.Parse(numInput);
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
    }
}