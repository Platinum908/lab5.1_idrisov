//Лаб 5.1 Высокий 20

Console.WriteLine("Введите текст до 100 слов: ");
char[] mas = Console.ReadLine().ToLower().ToCharArray();
for (int i = 0; i < 33; i++)
{
    int x = 0;
    int y = 0;
    for (int j = 0; j < mas.Length && Char.IsLetter(mas[j]) != true; j++) x++;
    for (int j = 0; j < mas.Length; j++)
    {
        if (Char.IsLetter(mas[i]) == true && mas[j] == mas[x])
        {
            y++;
            if (x != j) mas[j] = ' ';
        }
    }

    if (y > 0)
    {
        switch (y % 10)
        {
            case 2:
            case 3:
            case 4:
                Console.WriteLine($"буква {mas[x]} = {y} раза");
                break;
            default:
                Console.WriteLine($"буква {mas[x]} = {y} раз");
                break;
        }
        mas[x] = ' ';
    }
}