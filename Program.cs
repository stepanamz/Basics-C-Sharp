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
int numberA = new Random().Next(1,10); // случаное целое число от 1 до 9
Console.Write(numberA + " + ");
int numberB = new Random().Next(1,10);; // случаное целое число от 1 до 9
Console.Write(numberB);
int sum = numberA + numberB;
Console.WriteLine(" = " + sum);
