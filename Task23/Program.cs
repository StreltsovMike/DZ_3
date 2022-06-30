//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите N =  ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0;
int answ=1;

while (count < N)
{
    var number = Math.Pow(answ, 3);
    Console.WriteLine(number);
    answ++;
    count++;
}