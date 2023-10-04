namespace DianCalculator
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            int num1;
            int num2;
            int res;
            string symbol;

            Console.WriteLine("Welcome to Dian Simple Calculator");
            while(true) 
            {
                Console.WriteLine("Enter value for number 1:");
                while(true)
                {
                    if(int.TryParse(Console.ReadLine(), out num1))
                        {
                        break;
                    }
                    Console.WriteLine("Invalid Format.");
                }
                Console.WriteLine("Enter value for number 2:");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid Format.");
                }
                Console.WriteLine("Now enter symbol: (+,-,*,/)");
                while(true)
                {
                    symbol= Console.ReadLine();
                    if (symbol == "+")
                    {
                        res = num1 + num2;
                        Console.WriteLine("The result is: " + res);
                        break;
                    }
                    else if (symbol == "-")
                    {
                        res = num1 - num2;
                        Console.WriteLine("The result is: " + res);
                        break;
                    }
                    else if (symbol == "*")
                    {
                        res = num1 * num2;
                        Console.WriteLine("The result is: " + res);
                        break;
                    }
                    else if (symbol== "/")
                    {
                        if(num2<=0) 
                        {
                            Console.WriteLine("You can't divide lesser or equal to 0, please change value");
                            break;
                        }
                        else if(num2>num1)
                        {
                            Console.WriteLine("The resulted values are only whole numbers, please change value.");
                            break;
                        }
                        else
                        {
                            res = num1 / num2;
                            Console.WriteLine("The result is: " + res);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Format");
                    }
                }
            }
        }
    }
}