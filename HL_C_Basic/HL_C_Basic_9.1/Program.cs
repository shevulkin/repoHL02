using System.Text;
Console.OutputEncoding = Encoding.UTF8;
/* Опис: Ви отримали рядок, який містить ім’я та прізвище користувача.
 * Ваша мета - перевірити, чи починається прізвище на ту ж літеру,
 * що й ім’я. Якщо так, вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”,
 * інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.");
 */

Console.WriteLine("Введіть ім'я та прізвище користувача (через пробіл):");
string input = Console.ReadLine() ?? "";
int indexFirstName = 0;
int indexLastName = input.IndexOf(' ') + 1;
if (indexLastName > 0 && indexLastName < input.Length)
{
    if (input[indexFirstName] == input[indexLastName])
    {
        Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
    }
    else
    {
        Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
    }
}
else
{
    Console.WriteLine("Некоректний ввід. Будь ласка, введіть ім'я та прізвище через пробіл.");
}


