

Console.WriteLine("Entter first number: ");
Double firtsNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
Double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose operation (+, -, *, /):");
string operation = Console.ReadLine();

double result = 0;

switch(operation)
{
    case "+":
        result = firtsNumber + secondNumber;
        break;

    case "-":
        result = firtsNumber - secondNumber;
        break;

    case "*":
        result = firtsNumber * secondNumber;
        break;

    case "/":
        result = firtsNumber / secondNumber;
        break;

    default:
        Console.WriteLine("invalid transaction");
        break;
}

Console.WriteLine("Result: " + result);

