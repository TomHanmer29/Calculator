namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            
            Console.WriteLine("Enter first number:");
            string numOneInput = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string numTwoInput = Console.ReadLine();
            double numOne = double.Parse(numOneInput);
            double numTwo = double.Parse(numTwoInput);
            double product = numOne * numTwo;
            Console.WriteLine("The product of the two numbers is "+product);
        }
    }
}