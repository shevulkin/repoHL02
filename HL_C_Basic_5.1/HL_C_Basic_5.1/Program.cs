using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//ДЗ 5.1.Цикли
/*
1 Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. Після отримання всіх значень програма має обчислити та вивести середній заробіток.
2 Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок. Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.
3 Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. Просте число - це число, яке ділиться лише на 1 і на себе.
4 Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.
5 Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.
6 Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.
7 Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.
*/
bool needDo = true;
Console.WriteLine("Введіть номер завдання (1-7):");
string taskNumber = Console.ReadLine();
switch (taskNumber)
{
    case "1":
        goto case1;
    case "2":
        goto case2;
    case "3":
        goto case3;
    case "4":
        goto case4;
    case "5":
        goto case5;
    case "6":
        goto case6;
    case "7":
        goto case7;
    default:
        Console.WriteLine("Невірний номер завдання");
        break;
}

case1:
// 1 Обчислення середнього заробітку
int i = 0;
int sumSalary = 0;

while (needDo)
{
    Console.WriteLine($"Прицівник {i + 1}, яка вашааплата? Введітьлюбийтекст для завершеня");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int salary))
        {
        sumSalary += salary;
        i++;
    }
    else
    {
        needDo = false;
        continue;
    }
}
Console.WriteLine($"Середній заробіток {sumSalary / (i)}");
goto end;

case2:
// 2 Побудова графіку зірочками
Console.WriteLine($"Введіть кількість рядків");
while (needDo)
{
    Console.WriteLine($"Введіть кількість рядків");
    int input = int.Parse(Console.ReadLine());
    for (int j = 1; j <= input; j++)
    {
        for (int y = 1; y <= j; y++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

}
goto end;
//
case3:
// 3 Генерація простих чисел
Console.WriteLine("Введіть число, щоб потім розкласти на прості числа");
int inputNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Прості числа:");
for (int n = 2; n <= inputNumber; n++)
{
    bool isPrime = true;
    for (int d = 2; d <= Math.Sqrt(n); d++)
    {
        if (n % d == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(n);
    }
}
goto end;
//
case4 :
// 4 Генерація фібоначчівської послідовності
Console.WriteLine("Введіть кількість чисел Фібоначчі для генерації:");
int inputFib = int.Parse(Console.ReadLine());
int a = 0, b = 1;
if (inputFib == 1)
    Console.WriteLine(a);
else if (inputFib == 2)
    {
    Console.WriteLine(a);
    Console.WriteLine(b);
}
else
{
    Console.Write($"{a} {b} ");
    for (int f = 3; f <= inputFib; f++)
    {
        int c = a + b;
        Console.Write(c);
        Console.Write(" ");
        a = b;
        b = c;
        if (f == inputFib)
            Console.WriteLine();
    }
}

goto end;
//
case5:
// 5 Калькулятор оплати праці за годину
Console.WriteLine("Введіть кількість годин, відпрацюваних за день:");
int hours = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть розмір ставки за годину роботи:");
decimal rate = decimal.Parse(Console.ReadLine());
decimal dailyPay = hours * rate;
Console.WriteLine($"Оплата за день: {dailyPay} ");
goto end;
//
case6:
// 6 Генерація таблиці множення для конкретного числа
Console.WriteLine("Введіть число для генерації таблиці множення:");
int multiplyNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"Таблиця множення для числа {multiplyNumber}:");
for (int m = 1; m <= 10; m++)
{
    Console.WriteLine($"{multiplyNumber} x {m} = {multiplyNumber * m}");
}
goto end;
//
case7:
// 7 Перевірка на простоту
Console.WriteLine("Введіть число для перевірки на простоту:");
int inputNumberCheck = int.Parse(Console.ReadLine());
bool isPrimeCheck = true;
for (int d = 2; d <= Math.Sqrt(inputNumberCheck); d++)
{
    if (inputNumberCheck % d == 0)
    {
        isPrimeCheck = false;
        break;
    }
}
if (isPrimeCheck && inputNumberCheck > 1)
{
    Console.WriteLine($"{inputNumberCheck} - просте число.");
}
else
{
    Console.WriteLine($"{inputNumberCheck} - не є простим числом.");
}
goto end;
//
end:
Console.WriteLine("Дякую");