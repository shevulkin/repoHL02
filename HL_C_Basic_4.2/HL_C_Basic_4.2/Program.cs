/*
Заняття 4
ДЗ 4.2. Калькулятор
Користувач вводить два цiлих числа та математичну дію: + - * або /
Залежно від введеної математичної дії вивести результат в консоль.
Необхідно використати конструкцію switch у цьому завданні.
*/
//set unicode UTF8
Console.OutputEncoding = System.Text.Encoding.UTF8;
//first num
Console.WriteLine("Введіть перше число");
double x = double.Parse(Console.ReadLine());
//second num
Console.WriteLine("Ввеіть другечисло");
double y = double.Parse(Console.ReadLine());
//set action
Console.WriteLine("Ввеіть дію (+, -, *, /)");
string action = Console.ReadLine();
double result;
//do action
switch (action)
{
    case "+":
        result = x + y;
        break;
    case "-":
        result = x - y;
        break;
    case "*":
        result = x * y;
        break;
    case "/":
        if (y != 0)
        {
            result = x / y;
        }
        else
        {
            Console.WriteLine("Ділення на нуль неможливе.");
            return;
        }
        break;
    default:
        Console.WriteLine("Щосьне те");
        return;
}
//show result
Console.WriteLine($"Результат: {result}");
Console.WriteLine(result / 0);

