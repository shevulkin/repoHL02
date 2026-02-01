using System.Text;
Console.OutputEncoding = Encoding.UTF8;

/*
 * Створіть окремий статичний клас.
 * До нього треба додати рекурсивну функцію для обчислення числа Фібоначчі певного порядку.
 * Метод приймає номер числа і повертає число Фібоначчі вказаного номеру.
 * Вважати першим числом послідовності 0, другим — 1
Вхідний параметр: 3 
Вихідне значення: 1
Вхідний параметр: 11 
Вихідне значення: 55 
*/

Console.Write("Введіть номер числа Фібоначчі: ");
int n = int.Parse(Console.ReadLine());
int result = fib(n);
Console.WriteLine($"Число Фібоначчі під номером {n} дорівнює {result}.");

int fib(int value)
{
    //Виклик рекурсивної функції враховуючи інедексаці
    return calFib(value - 1);
}

int calFib(int value)
{
    //щоб вийти з рекурсії треба задати умови
    if (value < 0) return 0;
    if (value == 1) return 1;
    return calFib(value - 1) + calFib(value - 2);
}