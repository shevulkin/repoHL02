using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("1. Створити масив із 10 елементів типу int. ");
int[] arey = new int[10];
var rand = new Random();
int sum = 0;
for (int i = 0; i < arey.Length; i++)
{
    arey[i] = rand.Next(-10, 10);
    //Вивести на екран елементи масиву з парним індексом.
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    sum += arey[i];
}
//
//
//2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
Console.WriteLine("2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.");
if (sum < 0)
{
    Console.WriteLine($"Сума \"{sum}\" - від'ємне число");
}
else
{
    Console.WriteLine($"Сума {sum} - НЕ від'ємне число");
}
//
//
//3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
Console.WriteLine("3. Створити та заповнити двовимірний масив розміру 9х9");
int[,] ar2D = new int[9, 9];
// Заповнюємо масив
for (int i = 0; i < ar2D.GetLength(0); i++)
{
    for (int j = 0; j < ar2D.GetLength(1); j++)
    {
        ar2D[i, j] = (i + 1) * (j + 1);
    }
}
//виводимо
for (int i = 0; i < ar2D.GetLength(0); i++)
{
    for (int j = 0; j < ar2D.GetLength(1); j++)
    {
        Console.Write(ar2D[i, j] + "\t");
    }
    Console.WriteLine();
}
//
//4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. г) координати максимального елемента масиву.
Console.WriteLine("4 Створити двовимірний масив 5х5");
int[,] arD2for4 = new int[5, 5];
int minValue = 0;
int maxValue = 0;
int[] minIndex = new int[2];
int[] maxIndex = new int[2];
// Заповнюємо масив
for (int i = 0; i < arD2for4.GetLength(0); i++)
{
    for (int j = 0; j < arD2for4.GetLength(1); j++)
    {
        int valueRand = rand.Next();
        if (minValue > valueRand || i == 0 && j == 0)
        {
            minValue = valueRand;
            minIndex[0] = i;
            minIndex[1] = j;
        }

        if (maxValue < valueRand || i == 0 && j == 0)
        {
            maxValue = valueRand;
            maxIndex[0] = i;
            maxIndex[1] = j;
        }

        arD2for4[i, j] = valueRand;
    }
}
//виводимо
for (int i = 0; i < arD2for4.GetLength(0); i++)
{
    for (int j = 0; j < arD2for4.GetLength(1); j++)
    {
        Console.Write(arD2for4[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"min={minValue} minIndex={minIndex[0]}, {minIndex[0]}");
Console.WriteLine($"max={maxValue} maxIndex={maxIndex[0]}, {maxIndex[0]}");
//
//5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів, а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат. Наприклад: 
Console.WriteLine("5. За допомогою enum створити програму");
Console.WriteLine("Введіть скількість днів");
int days = int.Parse(Console.ReadLine());
int dayIndex = 0;
if (days > 6)
{
    dayIndex = days % 7;

}
else
{
    dayIndex = days;
}
//
if (Enum.IsDefined(typeof(Week), dayIndex))
{
    Week day = (Week)dayIndex;
    Console.WriteLine(day);
}
else
{
    Console.WriteLine("Такого дня тижня не існує!");
}
//
enum Week
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
