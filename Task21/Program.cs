//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите Xa =  ");
int Xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Ya =  ");
int Ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Za =  ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Xb =  ");
int Xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Yb =  ");
int Yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Zb =  ");
int Zb = Convert.ToInt32(Console.ReadLine());

//int Xa = 3, Ya = 6, Za = 8, Xb = 2, Yb = 1, Zb = -7;   // для проверки координаты из задания

var AB = Math.Round(Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2)));


Console.WriteLine("Расстояние мкжду точками = " + AB);