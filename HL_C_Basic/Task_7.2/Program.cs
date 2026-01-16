using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//
string[,] array2D = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
bool neddDo = true;
int counter = 0;
while (neddDo && counter < 12)
{
    Console.Clear();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + " | ");
        }

        Console.WriteLine("");
        Console.WriteLine("-----------");

    }
    //визначаємо гравця
    int user = 0;
    string setVal;
    if (counter % 2 == 0)
    {
        user = 1;
        Console.WriteLine("Гравець 1 введіть число");
        setVal = "X";
    }
    else
    {
        user = 2;
        Console.WriteLine("Гравець 2 введіть число");
        setVal = "O";
    }
    //вводимо число
    int input = int.Parse(Console.ReadLine());
    while (input < 1 || input > 12)
    {
        Console.WriteLine("Не вірно ввели");
        input = int.Parse(Console.ReadLine());
    }
    goto ok;
    //Значення зайняте, ще раз вводимо
shche:
    Console.WriteLine("Не вірно ввели");
    input = int.Parse(Console.ReadLine());
    //
    //перескакуємо shche
ok:
    switch (input)
    {
        case 1:
            if (array2D[0, 0] == "X" || array2D[0, 0] == "O")
            {
                goto shche;
            }
            array2D[0, 0] = setVal;
            break;
        case 2:
            if (array2D[0, 1] == "X" || array2D[0, 1] == "O")
            {
                goto shche;
            }
            array2D[0, 1] = setVal;
            break;
        case 3:
            if (array2D[0, 2] == "X" || array2D[0, 2] == "O")
            {
                goto shche;
            }
            array2D[0, 2] = setVal;
            break;
        case 4:
            if (array2D[1, 0] == "X" || array2D[1, 0] == "O")
            {
                goto shche;
            }
            array2D[1, 0] = setVal;
            break;
        case 5:
            if (array2D[1, 1] == "X" || array2D[1, 1] == "O")
            {
                goto shche;
            }
            array2D[1, 1] = setVal;
            break;
        case 6:
            if (array2D[1, 2] == "X" || array2D[1, 2] == "O")
            {
                goto shche;
            }
            array2D[1, 2] = setVal;
            break;
        case 7:
            if (array2D[2, 0] == "X" || array2D[2, 0] == "O")
            {
                goto shche;
            }
            array2D[2, 0] = setVal;
            break;
        case 8:
            if (array2D[2, 1] == "X" || array2D[2, 1] == "O")
            {
                goto shche;
            }
            array2D[2, 1] = setVal;
            break;
        case 9:
            if (array2D[2, 2] == "X" || array2D[2, 2] == "O")
            {
                goto shche;
            }
            array2D[2, 2] = setVal;
            break;
    }
    //
    //перевірка на перемогу
    //
    // Перевірка рядків (горизонталі)
    for (int i = 0; i < 3; i++)
    {
        if (array2D[i, 0] == array2D[i, 1] && array2D[i, 1] == array2D[i, 2])
        {
            Console.Clear();
            Console.WriteLine($"Гравець {user} переміг!");
            neddDo = false;
        }
    }
    //
    // Перевірка стовпців (вертикалі)
    for (int i = 0; i < 3; i++)
    {
        if (array2D[0, i] == array2D[1, i] && array2D[1, i] == array2D[2, i])
        {
            Console.Clear();
            Console.WriteLine($"Гравець {user} переміг!");
            neddDo = false;
        }
    }
    //
    // Перевірка діагоналей
    if ((array2D[0, 0] == array2D[1, 1] && array2D[1, 1] == array2D[2, 2]) ||
        (array2D[0, 2] == array2D[1, 1] && array2D[1, 1] == array2D[2, 0]))
    {
        Console.Clear();
        Console.WriteLine($"Гравець {user} переміг!");
        neddDo = false;
    }
    //
    // Перевірка на нічию
    if (counter == 8 && neddDo == true)
    {
        Console.Clear();
        Console.WriteLine("Нічия!");
        neddDo = false;
        continue;
    }
    counter++;
}