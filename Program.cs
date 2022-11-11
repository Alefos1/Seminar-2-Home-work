/*//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99]и
//показывает наибольшую цифру.

int FindBiggestDigit (int number)
{
    int ed = number % 10;          // еденицы
    int dec = number / 10;          // десятки
    //int result;

    if (ed > dec) return ed;
    else return dec;
}

int randNum = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(randNum);

Console.WriteLine($"The biggest digit of {randNum} is {biggestDigit}");
*/

/*//Напишите программу, которая выводит случайное трехзначное число и удалает 
//вторую цифру этого числа.

// abc = a * 100 + b * 10 + c
// a* 10 + c

int DeletSecondDigit (int num)
{
    int ditgit1 = num / 100;            // количество сотен (354 - 3)
    int ditgit3 = num % 10;             // количество едениц (з54 - 4)
    int res = ditgit1 * 10 + ditgit3;   
    return res;
}

int randNum = new Random().Next(100, 1000);
int result = DeletSecondDigit(randNum);

Console.WriteLine($"Result of convertation {randNum} is {result}");
*/

/*// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

void TwoNumber (int num1, int num2)
{
    int resNum = num2 % num1;
    if (resNum == 0)
    {
        Console.WriteLine($"{num2} is number{resNum}");
    }
    else
    {
        Console.WriteLine($"{num2} is not number {num1}. Reminder of divide is {num1}");
    }
}


Console.WriteLine("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
TwoNumber (num1, num2);
*/



/*//Задача 4. Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно a и b.

void Checknumbers (int num1, int a, int b)
{
    if (num1 % a == 0 & num1 % b == 0)
    {
        Console.WriteLine($"{num1} is multiply {a} and {b}");
    }
    else
    {
        Console.WriteLine($"{num1} is not multiply {a} and {b}");
    }
}

Console.WriteLine("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput second number: ");
int a = Convert.ToInt32(Console.ReadLine());    
Console.WriteLine("Imput third number: ");
int b = Convert.ToInt32(Console.ReadLine());    

Checknumbers (num1, a, b);
*/



/*//Задача 5. Напишите программу, которая принимает на вход два числа и проверяет,
//является ли одно число квадратом другого.


bool SquareOfTwoNumber (int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1) return true;
    else return false;
} 



Console.WriteLine("Imput first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());    
Console.WriteLine("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 

bool result = SquareOfTwoNumber(num1, num2);
if (result)
{
    Console.WriteLine($"One of the nummbers is square of another number.");
}
else
{
    Console.WriteLine($"No one of the nummbers is square of another number.");
}
*/