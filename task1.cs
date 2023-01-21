// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

int GetMyNumber()
{
    int result = 0;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result < 100000)
        {
            break;
        } else {
            Console.WriteLine("Вы ввели Неверное значение. введите пятизначное число");
        }

    }
    return result;
}

string palindrome(int number){
    if(number / 10000 == number % 10 && (number / 1000) % 10 == number % 100 / 10)
    return "да";
    else {
        return "нет";
    }
}

int number = GetMyNumber();
Console.WriteLine($"{number} -> {palindrome(number)}");
