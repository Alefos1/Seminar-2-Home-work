/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа/
*/

/*
int Three (int a)
{
a = a / 10 % 10;
return a;
}
Console.WriteLine ("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число на выходе: " + Three(a));
*/

//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

/*
int Four (int a)
{
    if ( a >= 100)
    {
        while (a > 999)
        {
            a = a / 10;
        }
        a = a % 10;
       Console.WriteLine (a);
    }
    else {
        Console.WriteLine("Третьей цифры нет ");
    }
    return a;
}
Console.WriteLine ("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Four (a);
*/

//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*
int Week ( int a)
{   if ( a < 8 & a > 0) {
        
    
    if (a < 6)
    {
        Console.WriteLine("Является рабочим днем");
    }
    else 
    {
        Console.WriteLine("Является выходным днем");
    }
} 
else {
    Console.WriteLine("Нет такого дня недели");
}
return a;
}
Console.WriteLine("Введите день недели ");
int a = Convert.ToInt32(Console.ReadLine());
Week (a);
