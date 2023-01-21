// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int GetMyNumber()
{
    int result = -1;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        } else {
            Console.WriteLine("Вы ввели Неверное значение. введите число, кроме нуля");
        }

    }
    return result;
}

int cube(int number){
    return number * number * number;
}

int number = GetMyNumber();
int count = 1;
Console.Write($"{number} -> ");
while(count < number){
    Console.Write(cube(count) + ", ");
    count++;
}
Console.Write(cube(number) + ".");
