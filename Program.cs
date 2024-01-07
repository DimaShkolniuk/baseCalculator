internal class Program
{
    private static void Main(string[] args)
    {
      do{

        double num1 = 0;
        double num2 = 0;
        double result = 0;

        System.Console.WriteLine("------------------");
        System.Console.WriteLine("Calculator Program");
        System.Console.WriteLine("------------------");

        System.Console.WriteLine("Enter number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Enter number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        
        System.Console.WriteLine("Enter an option: ");
        System.Console.WriteLine("\t+ : Add");
        System.Console.WriteLine("\t- : Subtract");
        System.Console.WriteLine("\t* : Multiply");
        System.Console.WriteLine("\t/ : Divide");
        System.Console.Write("Enter an option");

        switch(Console.ReadLine())
        {
          case "+":
            result = num1 + num2;
            System.Console.WriteLine($"Your result: {num1} + {num2} = {result}");
            break;
          case "-":
            result = num1 - num2;
            System.Console.WriteLine($"Your result: {num1} - {num2} = {result}");
            break;
          case "*":
            result = num1 * num2;
            System.Console.WriteLine($"Your result: {num1} * {num2} = {result}");
            break;
          case "/":
            if (num2 == 0)
            {
              System.Console.WriteLine("Don't cane divide at zero!");
            }
            else
            {
              result = num1 / num2;
              System.Console.WriteLine($"Your result: {num1} / {num2} = {result}");
            }
            break;
          default:
            System.Console.WriteLine("That was not valid option");
            break;
        }

        System.Console.WriteLine("Would you like to continue? (Y/N)");
      }while(Console.ReadLine().ToUpper() == "Y");

      System.Console.WriteLine("Bye!");
    }
}