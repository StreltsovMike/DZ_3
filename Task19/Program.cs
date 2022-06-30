//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// ПРОГРАММА ОПРЕДЕЛЯЕТ ПОЛИНДРОМ НЕЗАВИСИМО ОТ КОЛ-ВА ЦИФР В ЧИСЛЕ
// ЕСЛИ НЕОБХОДИМА ПРОВЕРКА НА ПЯТИЗНАЧНОСТЬ, СОТРИТЕ ВСЕ НИЖЕСТОЯЩИЕ "//"


int Revers(int arg)
{
    int revers = 0, n;
    while (arg > 0)
    {
        n = arg % 10;
        revers = revers * 10 + n;
        arg = arg / 10;
    }
    return revers;
}

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

//if (number < 99999 && number > 10000)
//{

    int revers = Revers(number);


    if (number == revers)
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
//}
//else
//{
//    Console.WriteLine("Вы ввели не пятизначное число");
//}