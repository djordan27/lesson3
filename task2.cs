

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Начинаем работать");



 int GetOneCoordinats () {
    int result = 0;
    while (true) {
        
        if(int.TryParse(Console.ReadLine(), out result)){
        break;
        
        } else {
            Console.WriteLine("вы ввели недопустимое значение");
        }
    }
    return result;
}

void GetTreeCoordinat(int [] first, int [] second) {
  
  Console.WriteLine("Введите координаты для первой точки");
  first[0] = GetOneCoordinats();
  first[1] = GetOneCoordinats();
  first[2] = GetOneCoordinats();
 
  Console.WriteLine("Введите координаты для первой точки");
  second[0] = GetOneCoordinats();
  second[1] = GetOneCoordinats();
  second[2] = GetOneCoordinats();

}

int []firstDot = new int [3];
int []secondDot = new int [3];

GetTreeCoordinat(firstDot, secondDot); 
double result = Math.Sqrt(Math.Pow(firstDot[0] - secondDot[0], 2) + Math.Pow(firstDot[1] - secondDot[1], 2)  + Math.Pow(firstDot[2] - secondDot[2], 2));
result=Math.Round(result, 2);
Console.WriteLine($"{result}");