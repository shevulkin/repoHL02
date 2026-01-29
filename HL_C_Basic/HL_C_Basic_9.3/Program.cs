using System.Text;
Console.OutputEncoding = Encoding.UTF8;
/*
 * Ви отримали рядок, який містить декілька слів, розділених комами.
 * Ваша мета - видалити всі пробіли з цього рядка та вивести результат.
 */
Console.WriteLine("Введіть рядок з кількома словами, розділеними комами:");
string input = Console.ReadLine() ?? "";
StringBuilder resultBuilder = new StringBuilder();
foreach (char c in input)
{
    if (c != ' ')
    {
        resultBuilder.Append(c);
    }
}
Console.WriteLine("Результат без пробілів:");
Console.WriteLine(resultBuilder.ToString());