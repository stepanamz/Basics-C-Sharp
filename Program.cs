// Hello User
// Console.Write("Введите ваше имя ");
// string username = Console.ReadLine();
// Console.Write("Привет, " + username);

// Сложение двух целых чисел
// int numberA = 3;
// int numberB = 5;
// int sum = numberA + numberB;
// Console.WriteLine(sum);

// Деление с дробной частью
// double numberA = 12;
// double numberB = 5;
// double sum = numberA / numberB;
// Console.WriteLine(sum);

// Случайные числа сложение
// int numberA = new Random().Next(1,10); // случаное целое число от 1 до 9
// Console.Write(numberA + " + ");
// int numberB = new Random().Next(1,10);; // случаное целое число от 1 до 9
// Console.Write(numberB);
// int sum = numberA + numberB;
// Console.WriteLine(" = " + sum);

// Условие для конкретного пользователя
// Console.Write("Введите имся пользователя: ");
// string username = Console.ReadLine();

// if(username.ToLower() == "Маша")
// {
//     Console.WriteLine("Ура это же МАША !");

// }
// else {

//     Console.Write("Привет, " + username);

// }

// Нахождение максимального эллемента из приведенных ниже
// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;

// if  ( a > max ) max = a ;
// if  ( b > max ) max = b ;
// if  ( c > max ) max = c ;
// if  ( d > max ) max = d ;
// if  ( e > max ) max = e ;
// Console.WriteLine("max = " + max);

//какой то треугольник
Console.Clear();
int xa = 80, ya = 1;
int xb = 1, yb = 40;
int xc = 160, yc = 40;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
        {
            x = (x+xa) / 2;
            y = (y+ya) / 2;
        }

        if(what == 1)
        {
            x = (x+xb) / 2;
            y = (y+yb) / 2;

        }

         if(what == 2)
        {
            x = (x+xc) / 2;
            y = (y+yc) / 2;

        }

        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
        count = count + 1;



}