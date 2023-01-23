// Задача №1 Пример преподавателя
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите целое число"); // приглашаем пользователя ввести информацию
// //int x = Convert.Readline(); // вводили для эксперимента, выводит ошибку
// int x = Convert.ToInt32(Console.ReadLine()); //перевели данные от пользователя в целое 
//                                             //число и спрятали в переменну х тоже целочисленного типа
// int y = x*x; // посчитали квадрат
// Console.WriteLine("квадрат введенного числа равен "+y); //вывели квадрат на экран

// // сделаем проверку на двузначность числа
// if (x>9 && x<100)   // если х больше 9 и одновременно меньше 100 то делаем следующее:
// {
//    Console.WriteLine("Вы ввели положительное двузначное число");
//}
// Задача 2. Самостоятельное групповое решение

//Console.WriteLine (" Введите число 1  ");

//int x = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine(" Введите число 2  ");

//int y = Convert.ToInt32 (Console.ReadLine());

//if ( x == y*y )
//{
//    Console.WriteLine(" Первое число является квадратом второго  ");
//}
//else
//{
//    Console.WriteLine(" Первое число не является квадратом второго  ");
//}

// Задача №3, самостоятельная групповая работа

//Console.WriteLine(" Введите число от 1 до 7  ");
//int x = Convert.ToInt32 (Console.ReadLine());
//if (x == 1) Console.WriteLine(" Понедельник  ");
//else if (x == 2) Console.WriteLine(" Вторник  ");
//else if (x == 3) Console.WriteLine(" Среда  ");
//else if (x == 4) Console.WriteLine(" Четверг  ");
//else if (x == 5) Console.WriteLine(" Пятница  ");
//else if (x == 6) Console.WriteLine(" Суббота  ");
//else if (x == 7) Console.WriteLine(" Воскресенье  ");
//else Console.WriteLine ("Некорректное число");

// Задача №4, от преподавателя (с циклом)

Console.WriteLine("Введите целое число"); // приглашаем пользователя ввести информацию
int x = Convert.ToInt32(Console.ReadLine());
int i =1;
while (i<=x)
{
    Console.Write(i + " ");
    i=i+1;
}