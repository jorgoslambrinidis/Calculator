
using Calculator;

Initialization initialization = new Initialization();
initialization.Init();

Calculations calculations = new Calculations();

Console.WriteLine("Enter first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************\n");
Console.WriteLine("Enter symbol(/,+,-,*):\n");

string symbol = Console.ReadLine();
Console.WriteLine("***************************************************\n");


switch (symbol)
{
    case "+": calculations.Addition(num1, num2); break;

    case "-": calculations.Substruction(num1, num2); break;

    case "*": calculations.Multiplication(num1, num2); break;

    case "/": calculations.Division(num1, num2); break;

    default: Console.WriteLine("Nepravilna Operacija"); break;
}

Console.ReadLine();



//if (symbol == "+")
//{
//    // sobiranje
//    Console.WriteLine($"Operacija Sobiranje: {num1 + num2}");
//}
//else if (symbol == "-")
//{
//    // odzemanje
//    var odzemanjeRez = num1 - num2;
//    Console.WriteLine($"Operacija Odzemanje: {odzemanjeRez}");
//}
//else if (symbol == "*")
//{
//    // mnozenje
//    var mnozenjeRez = num1 * num2;
//    Console.WriteLine($"Operacija Mnozenje: {mnozenjeRez}");

//}
//else if (symbol == "/")
//{
//    // delenje
//    var delenjeRez = num1 / num2;
//    Console.WriteLine($"Operacija delenje: {delenjeRez}");
//}
//else
//{
//    Console.WriteLine("Nepravilna Operacija");
//}


