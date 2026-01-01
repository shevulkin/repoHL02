// Користувач вводить із клавіатури номер дня тижня (1-7).
// Необхідно вивести на екран назви дня тижня. Наприклад, якщо 1, на екрані напис понеділок, 2 — вівторок тощо.
int num;
string day;

Console.WriteLine("Введть номер дня тижня");
num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        day = "Понеділок";
        break;
    case 2:
        day = "Вівторок";
        break;
    case 3:
        day = "Середа";
        break;
    case 4:
        day = "Четверг";
        break;
    case 5:
        day = "П'ятниця";
        break;
    case 6:
        day = "Субота";
        break;
    case 7:
        day = "Неділя";
        break;
    default:
                day = "Некоректний номер дня тижня";
        break;
}

Console.WriteLine($"{num} - день тижня це {day}");