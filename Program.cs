// №1 Напишите прграмму, которая принимает на вход трехзначное число и на выходе показывает
  //   вторую цифру  этого числа.
/*
int FindNum(int num)
{
int n1 = (num / 10) % 10;
return n1;
}
int number = new Random().Next(100, 999);
Console.WriteLine("Corent numder is " + number +  " -->  " + FindNum(number));
*/

// №2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

/*
    
    int Rezalt( int num){
  
    if( num  >= 100  && num <= 999 )
    {
     int velue = num % 10;
     Console.WriteLine( + velue + " Третья цифра  " );
    }

     if( num >= 1000 && num <= 9999) 
    {
         int velue = (num / 10) % 10;
     Console.WriteLine( + velue + " Третья цифра  "); 
    }
    if(num >= 10000 && num <= 99999)
   {
    int velue =((num / 10) / 10) % 10;
    Console.WriteLine( + velue + " Третья цифра  " ); 
    }

    if( num < 100)

    {
         Console.WriteLine(" Нет третьей цифры  "); 
    }
     return num;


 }
     Console.WriteLine(" Введите число    ");
int number = Convert.ToInt32(Console.ReadLine());
    Rezalt(number);

*/
// №3 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 // и проверяет, является ли этот день выходным.

/*

Console.WriteLine(" Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1 && number <= 7)
{
    if(number == 6 || number ==7)
    {
    Console.WriteLine(" Holliday");   
    }
    if(number >= 1 && number <= 5)
    {
    Console.WriteLine(" Work day");
    }
}
else
{
    Console.WriteLine(" It dosn't day of the week");        
}
*/
// это все


// Домашнее задание № 3
// Задача № 1.Дано пятизначное число. Проверить является ли оно палиндромом.

/*

 int Proverka( int num){
int a = num / 10000;//  первая цифра числа
int b = (((num / 10 ) / 10) / 10) %10; // вторая цифра числа
int c = (num / 10) % 10;// четвертая цифра числа
int d = num % 10;//пятая цифра числа

if( a == d && b == c){
Console.WriteLine( + num + " палиндром");
}
else{

    Console.WriteLine( + num + " не является палиндромом");
}
return num;
 }
 Console.WriteLine(" Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Proverka(number);
*/

// Задача №2.Напишите программу, которая принимает на вход координаты двух точек 
//                и находит расстояние между ними в 3D пространстве.
/*
double Distens(double xa, double ya, double za, double xb, double yb, double zb){
   double Xdist = Math.Pow (( xa - xb), 2);
   double Ydist = Math.Pow (( ya - yb), 2);
   double Zdist = Math.Pow (( za - zb), 2);
   double rezalt =  Math.Sqrt (Xdist + Ydist + Zdist);
   return rezalt;
}
double AB;
Console.Write("Input xa:   ");
 double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ya:   ");
 double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input za:   ");
 double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xb:   ");
 double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yb:   ");
 double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zb:   ");
 double zB = Convert.ToDouble(Console.ReadLine());
 AB = Distens( xA, yA, zA, xB, yB, zB);
Console.WriteLine( " Растояние между точками A и В равно:  " + AB);
*/

//  Задача №3       Напишите программу, которая принимает на вход число (N) и
//                   выдаёт таблицу кубов чисел от 1 до N.
/*
 Console.WriteLine(" Введите число:  ");
 int n = Convert.ToInt32(Console.ReadLine());
 int i = n;
 i = 1;
 while( i <= n){
      int count = (i * i) * i;

     Console.Write( + count  + ",");

     i++;
 }
*/

// 2-й вариант решения с помощью метода.
/*
 int Kub( int n ){
  int i = n;
  i = 1;
  int count = 1;
  while ( i <= n){
      count = (i * i) * i;

    Console.Write( + count  + ",");
    i++;
   }
   return count;

  } 
Console.WriteLine(" Введите число:  ");
 int nomber = Convert.ToInt32(Console.ReadLine());
 Kub(nomber);

*/
