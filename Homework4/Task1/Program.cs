// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32 (Console.ReadLine());

int res = RiseToPower (a,b);
System.Console.WriteLine(res);

int RiseToPower (int num1, int num2)
{
     int power = Convert.ToInt32 (Math.Pow (num1, num2));

return power;
}

