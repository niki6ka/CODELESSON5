// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int ArrLen = 10;
int[] Numbers = new int[ArrLen];
int notevensum = 0;
int maxnumber = 0;
int minnumber = 1000;
int difference = 0;
int Task = 0;
int evensum = 0;

void FillArray(int[] Numbers)
{
    int index = 0;
    while (index < ArrLen)
    {
        Numbers[index] = new Random().Next(100, 1000);
        
        Console.Write(Numbers[index] + " ");
          if (Numbers[index] % 2 == 0)
              {evensum = evensum + 1;}
        if (index % 2 == 1)
        {notevensum = notevensum + Numbers[index];}
        if (Numbers[index] > maxnumber) {maxnumber = Numbers[index];}
        if (Numbers[index] < minnumber) {minnumber = Numbers[index];}

        index++;
    }
    difference = maxnumber - minnumber;
 
 }
FillArray(Numbers);
  Console.WriteLine(" - given array of random numbers");
  Console.WriteLine();
  Console.WriteLine("1) Number of even numbers");
  Console.WriteLine("2) The sum of numbers at odd indices");
  Console.WriteLine("3) The difference between the maximum and minimum number");
Task = Convert.ToInt32(Console.ReadLine());
  switch (Task)
{
    case 1:
        Console.WriteLine("Number of even numbers " + evensum);
        break;
    case 2:
        Console.WriteLine("The sum of numbers at odd indices " + notevensum);
        break;
    case 3:
        Console.WriteLine("The difference between the maximum and minimum number " + difference);
        break;
}
