using System.Text;
Console.OutputEncoding = Encoding.UTF8;
/*
Написати програму, що знаходить другий найбільший елемент масиву.
Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.
*/

Console.WriteLine("Введіть номер завдання (1-4):");
Console.WriteLine("1. Знаходження другого найбільшого елемента масиву");
Console.WriteLine("2. Сортування за зростанням елементів двовимірного масиву");
Console.WriteLine("3. Видалення з масиву елемента за вказаним індексом");
Console.WriteLine("4. Знаходження суми елементів по діагоналі у двовимірному масиві"); 
string taskNumber = Console.ReadLine() ?? "";

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

    default:
        Console.WriteLine("Невірний номер завдання");
        break;
}

case1:
int[] array1 = { 1, 5, 3, 2, 6, 6, 1, 4 };
Console.WriteLine("Масив: " + string.Join(", ", array1));
int firstMax = 0;
int secondMax = 0;
    
foreach (int num in array1)
{
    if (num > firstMax)
    {
        secondMax = firstMax;
        firstMax = num;
    }
    else if (num > secondMax && num != firstMax)
    {
        secondMax = num;
    }
}
Console.WriteLine($"Другий найбільший елемент масиву: {secondMax}");
goto end;

case2:
int[,] array2D = { { 3, 2, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };
int rows = array2D.GetLength(0);
int cols = array2D.GetLength(1);
int[] flatArray = new int[rows * cols];
int index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        flatArray[index++] = array2D[i, j];
    }
}
Array.Sort(flatArray);
index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array2D[i, j] = flatArray[index++];
    }
}
Console.WriteLine("Відсортований двовимірний масив:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array2D[i, j] + " ");
    }
    Console.WriteLine();
}
goto end;

case3:
int[] array3 = { 1, 5, 3, 2, 6, 6, 1, 4 };
Console.WriteLine("Масив: " + string.Join(", ", array3));
Console.WriteLine("Введіть індекс елемента для видалення (0-" + (array3.Length - 1) + "):");
int indexToRemove = int.Parse(Console.ReadLine() ?? "0");
if (indexToRemove < 0 || indexToRemove >= array3.Length)
{
    Console.WriteLine("Невірний індекс");
}
else
{
    int[] newArray = new int[array3.Length - 1];
    for (int i = 0, j = 0; i < array3.Length; i++)
    {
        if (i != indexToRemove)
        {
            newArray[j++] = array3[i];
        }
    }
    Console.WriteLine("Масив після видалення: " + string.Join(", ", newArray));
}
goto end;

case4:
    int[,] array4 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 2 } };
Console.WriteLine("Двовимірний масив:");
for (int i = 0; i < array4.GetLength(0); i++)
{
    for (int j = 0; j < array4.GetLength(1); j++)
    {
        Console.Write(array4[i, j] + " ");
    }
    Console.WriteLine();
}

int diagonalSum1 = 0;
int diagonalSum2 = 0;
    for (int i = 0; i < array4.GetLength(0); i++)
    {
        diagonalSum1 += array4[i, i];
    }
    Console.WriteLine($"Сума елементів по діагоналі - 1: {diagonalSum1}");
    for (int i = 0; i < array4.GetLength(0); i++)
    {
        diagonalSum2 += array4[i, array4.GetLength(1) - 1 - i];
}
    Console.WriteLine($"Сума елементів по діагоналі - 2: {diagonalSum2}");
goto end;

end:
Console.WriteLine("Дякую");



