// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int ArrLen = 10;
int[] Numbers = new int[ArrLen];
int notevensum = 0;
void FillArray(int[] Numbers)
{
    int evensum = 0;
    int index = 0;
    while (index < ArrLen)
    {
        Numbers[index] = new Random().Next(100, 1000);
        
        Console.Write(Numbers[index] + " ");
          if (Numbers[index] % 2 == 0)
              {evensum = evensum + 1;}
        if (index % 2 == 1)
        {notevensum = notevensum + Numbers[index];}

        index++;
    }
   Console.Write("Even number " + evensum + "Sum of numbers at odd indices = " + notevensum); 
}

FillArray(Numbers);
