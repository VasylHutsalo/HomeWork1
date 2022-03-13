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