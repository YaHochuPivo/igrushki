// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

Console.WriteLine("Привет, давай поиграем?");
Console.WriteLine("Выбери игру:");
Console.WriteLine("1. Угадай число");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывод делителей числа");
Console.WriteLine("4. Выход");
int ch = Convert.ToInt32(Console.ReadLine());


while (ch != 4)
    

{
    if (ch == 1)
    {

        Console.WriteLine("Игра - Угадай число!");
        Console.WriteLine("Введите число от 0 до 10: ");
        int k;
        Random rand = new Random(10);
        int i = rand.Next(0, 10);
        do
        {
            k = Convert.ToInt32(Console.ReadLine());
            if (i == k)
            {
                Console.WriteLine("Вы угадали!");

                break;
            }
            if (i != k)
                Console.WriteLine("Попробуйте другое число");
        } while (i != k || k > 10);
        break;
    }


    if (ch == 2)
    {
        int i;
        int[,] umn = new int[9, 9] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };

        for (int m = 0; m < umn.GetLength(0); m++)
        {
            i = 1 + m;
            for (int n = 0; n < umn.GetLength(1); n++)
            {
                Console.Write(umn[m, n] * i + "\t");
            }
            Console.WriteLine();
            
        } break;
    }
    if (ch == 3)
    {

        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        for (int a = 1; a <= num; a++)

            if (num % a == 0)
            {
                Console.Write("{0} ", a);
            }

    }

}






