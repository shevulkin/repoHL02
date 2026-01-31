using System.Text;
Console.OutputEncoding = Encoding.UTF8;

/*
 * Написати свій власний варіант гри “Шибениця”. Це гра, де треба вгадати посимвольно зашифроване слово. 
 * Нехай слово вже буде відомо програмі. Користувач може вводити по одній літері та має обмежену кількість невірних спроб.
 * Очікувана гра має виглядати приблизно наступним чином:

Copy code
Вітаємо! Спробуйте вгадати зашифроване слово! 
Кількість літер у слові: 6
Кількість можливих невірних спроб: 6

Введіть вашу літеру: у
Такої літери немає! Залишилось спроб: 5
Введіть вашу літеру: н
Такої літери немає! Залишилось спроб: 4
Введіть вашу літеру: а
Така літера є у слові! Позиція літери: 4,6
Введіть вашу літеру: о
Така літера є у слові! Позиція літери: 2
Введіть вашу літеру: с
Така літера є у слові! Позиція літери: 1
Введіть вашу літеру: з
Такої літери немає! Залишилось спроб: 3
Введіть вашу літеру: б
Така літера є у слові! Позиція літери: 3
Введіть вашу літеру: к

Вітаємо, ви вгадали слово! Зашифроване слово: собака.
Дякуємо за гру.
 */

string secretWord = "кописток";
int maxWrongAnswers = 6;
int wrongAnswers = 0;
char[] charsWord = secretWord.ToCharArray();
int guessedСountСhar = 0;
//Шифруємо слово
for (int i = 0; i < charsWord.Length; i++)
{
    charsWord[i] = '*';
}

Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
do
{
    Console.WriteLine(charsWord);
    Console.WriteLine($"Кількість літер у слові: {charsWord.Length}");
    Console.WriteLine($"Кількість можливих невірних спроб: {maxWrongAnswers - wrongAnswers}");
    Console.Write("Введіть вашу літеру: ");
    string input = Console.ReadLine();
    char guessedChar = input[0];
    int positions = 0;
    for (int i = 0; i < charsWord.Length; i++)
    {
        //чи називали
        if (charsWord[i] == guessedChar)
        {
            positions = i + 1;
            Console.WriteLine($"Ви вже називали цю літеру! Позиція літери: {i + 1}");
            break;
        }
        //вгадана літера
        if (secretWord[i] == guessedChar)
        {
            positions = i + 1; // Позиція починається з 1
            guessedСountСhar++;
            charsWord[i] = guessedChar;
            Console.WriteLine($"Така літера є у слові! Позиція літери: {positions}");
        }
        //перевірка на виграш
        if (guessedСountСhar == charsWord.Length)
        {
            Console.WriteLine($"Вітаємо, ви вгадали слово! Зашифроване слово: {secretWord}.");
            Console.WriteLine("Дякуємо за гру.");
            break;
        }
    }
    //невірна відповідь
    if (positions == 0)
    {
        wrongAnswers++;
        Console.WriteLine($"Такої літери немає! Залишилось спроб: {maxWrongAnswers - wrongAnswers}");
    }
} while (wrongAnswers < maxWrongAnswers && guessedСountСhar < secretWord.Length);