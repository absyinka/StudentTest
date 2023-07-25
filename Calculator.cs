using System;

namespace Umar
{
    class Calculator
    {
		public void CalculatorInputs()
		{
			try
			{
				bool flag = true;

				do
				{
					Console.Write("Enter your first number: ");
					double firstInput = InputConverter.ConvertInputToNumeric(Console.ReadLine());

					Console.Write("Enter your operator: ");
					string arithmeticOperator = Console.ReadLine();

					Console.Write("Enter your second number: ");
					double secondInput = InputConverter.ConvertInputToNumeric(Console.ReadLine());

					var output = CalculatorEngine(firstInput, secondInput, arithmeticOperator);

					Console.WriteLine(output);

					string continueOption = string.Empty;
					do
					{
						Console.Write("Do you want to continue Y/N: ");
						continueOption = Console.ReadLine();

					} while (continueOption != "y" && continueOption != "n");

					flag = continueOption == "y";

				} while (flag);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		private double CalculatorEngine(double argNumber1, double argNumber2, string argOperation)
        {
            double result;

            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argNumber1 + argNumber2;
                    break;
                case "minus":
                case "-":
                    result = argNumber1 - argNumber2;
                    break;
                case "multiply":
                case "*":
                    result = argNumber1 * argNumber2;
                    break;
                case "divide":
                case "/":
                    result = argNumber1 / argNumber2;
                    break;
                case "modulo":
                case "%":
                    result = argNumber1 % argNumber2;
                    break;
                default:
                    throw new InvalidOperationException("Operator not recognized!");
            }

            return result;
        }
    }
}