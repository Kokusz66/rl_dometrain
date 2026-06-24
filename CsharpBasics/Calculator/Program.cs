public class Program
{
    public class Calculator
    {
        private string greeting;

        public Calculator(string greeting)
        {
            this.greeting = greeting;
        }

        public string GetGreeting()
        {
            return this.greeting;
        }

        public void SetFromConsoleGreeting()
        {
            Console.WriteLine("Give me the message: ");
            string greeting = Console.ReadLine();
            this.greeting = greeting;
        }

        public void Start(string message)
        {
            Calculator calc = new Calculator(message);
            Console.WriteLine(calc.GetGreeting());
            Dictionary<string, string> supportedOperators = new()
        {
            { "+", "Add" },
            { "/", "Divide" },
            { "-", "Minus" },
            { "*", "Multiply" },
            { "@", "exit" }
        };

        while (true)
        {
            Console.WriteLine("Opetarot choises:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.WriteLine("Enter an operator:");
            string operatorChoise = Console.ReadLine();

                if (operatorChoise == "@")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            if (!supportedOperators.TryGetValue(operatorChoise, out var selectedOperatorDescription))
            {
                    Console.WriteLine("Invalid operator choice.");
                    continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine($"Recall that integers are on the range " + 
            $"{int.MinValue} to {int.MaxValue}!");
            Console.WriteLine();


            Console.WriteLine("Enter the first integer:");
            string firstNumberInput = Console.ReadLine();
                if (!int.TryParse(firstNumberInput, out int firstNumber))
                {
                    Console.WriteLine($"{firstNumberInput} could not be parsed as an integer!");
                    continue;
                }

                Console.WriteLine("Enter the second integer:");
                string secondNumberInput = Console.ReadLine();
                if (!int.TryParse(secondNumberInput, out int secondNumber))
                {
                    Console.WriteLine($"{secondNumberInput} could not be parsed as an integer!");
                    continue;
                }

                int result;
                try
                {
                    result = operatorChoise switch
                    {
                        "+" => firstNumber + secondNumber,
                        "/" => firstNumber / secondNumber,
                        "-" => firstNumber - secondNumber,
                        "*" => firstNumber * secondNumber,
                        _ => throw new NotSupportedException(
                            $"Arithmetic is not currently supported " +
                            $"for operator {operatorChoise}.")
                    };
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero!");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"There was an unhandled exception: {e.Message}");
                    continue;
                }

                Console.WriteLine($"The resilt is: {result}");

            }
        }

        //public string GreetingsMessage()
        //{
        //    Console.WriteLine("Give me the greeting message:");
        //    string result = Console.ReadLine();
        //    return result;
        //}

        
    }

    private static void Main(string[] args)
    {
        //betettem az egészet a Calculator osztályba, talán szebb így
        string m = "Hello User!";
        Calculator calc = new Calculator(m);
        calc.Start(m);
    }
}