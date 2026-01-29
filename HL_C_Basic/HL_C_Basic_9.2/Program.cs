using System.Text;
Console.OutputEncoding = Encoding.UTF8;
/*
 * Ви розробляєте програму для генерації текстового звіту.
 * Ваше завдання - створити текстовий звіт, який містить заголовок, дату та список подій.
 * Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків.
 * Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder .
*/

Console.WriteLine("Введіть заголовок звіту:");
string reportTitle = Console.ReadLine() ?? "";
StringBuilder reportBuilder = new StringBuilder();
reportBuilder.AppendLine(reportTitle);
reportBuilder.AppendLine($"Дата звіту: {DateTime.Now.ToString("dd.MM.yyyy")}");
reportBuilder.AppendLine("Список подій:");
do
{
    Console.WriteLine("Введіть подію (або 'Y' для завершення):");
    string eventInput = Console.ReadLine() ?? "";
    if (eventInput == "Y")
    {
        break;
    }
    reportBuilder.AppendLine($"- {eventInput}");
} while (true);
Console.WriteLine(reportBuilder.ToString());

