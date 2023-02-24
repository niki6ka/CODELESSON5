// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int ArrLen = 10;
int[] Numbers = new int[ArrLen];
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
        index++;
    }
   Console.Write("Even number " + evensum); 
}

FillArray(Numbers);
