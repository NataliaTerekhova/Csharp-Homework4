//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result= GetDigitSum (number);
System.Console.WriteLine(result);

int GetDigitSum(int num)
{
int count=0;
int sum =0; 
while (num>0)
{
    int num1=num%10;
    sum = sum+num1;
    num/=10;
    count++;
}
return sum;
}



// static int GetCountNum(int num)
// {
// System.Console.WriteLine(num);
// int count=0;
//    while (num>0)
//    {
//    count++;
//    num/=10;
//    }
//    return count;
// }