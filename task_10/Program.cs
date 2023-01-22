//program takes 3-digit number and shows 
//the second digit of this number
int GetUserNumber(string message)
{
    Console.WriteLine(message);
    int ThreeDigitNumber = int.Parse(Console.ReadLine()!); 
    return ThreeDigitNumber;
}
int N= GetUserNumber("Input three-digit number");
int Div1 = N/10;
int Div2 = Div1%10;
Console.WriteLine($" {Div2} is the second digit");

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int [] GetRandomArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         array [i] = new Random().Next(-100, 100);
    }
    return array;
}
int [] Array = GetRandomArray (10); 

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);

int GetMaxNumber (int [] Array)
{
    int i = 0;
    int Max = Array[i];
    while (i <Array.Length)
    {
        if (Array[i]>Max)
        {
         Max = Array[i];
         i ++;
        }
        else 
        {
            i ++;
        }
    }
return Max;
}
int MaxResult = GetMaxNumber (Array);

int GetMinNumber (int [] Array)
{
int i = 0;
int Min = Array[i];

     while (i<Array.Length)
     {
      if (Array[i]<Min)
      {
      Min= Array[i];
      i++;
      }
      else 
      {
        i++;
      }
     }
return Min;
}
int MinResult = GetMinNumber (Array);
int FindMAxMinDiff (int MaxResult, int MinResult)
{
 int Diff = MaxResult-MinResult;
return Diff;
}
int difference = FindMAxMinDiff (MaxResult, MinResult);
Console.WriteLine();
Console.WriteLine ($"The difference between Max and Min numbers is {difference}"!);   




//  34 Create an array with random positive three digit numbers 
// write the programm which shows the quantity of positive ordinary numbers 
// [345, 897, 568, 234] -> 2
int [] GetRandomArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         array [i] = new Random().Next(99, 1000);
    }
    return array;
}
int [] Array = GetRandomArray (5); 

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);
int CountPositiveOrdinary (int []Array)
{
int Count =0;
   for (int i = 0;i < Array.Length; i++)
   {
    
    if (Array[i]%2 ==0)
    {
        Count=Count+1; 
    }
    
   }
   return Count;
}
int Result = CountPositiveOrdinary (Array);
if (Result<2 && Result>0)
{
Console.WriteLine();
Console.WriteLine($"There is {Result} ordinary number in this array");
}
else
Console.WriteLine();
Console.WriteLine($"There are {Result} positive ordinary numbers in this array");



// Задача 36: Create an array, filled with random numbers. 
// Find the sum of the numbers in odd positions
// [3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int [] GetRandomArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         array [i] = new Random().Next(-10, 10);
    }
    return array;
}
int [] Array = GetRandomArray (10); 

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);
int GetOddNumbersSum (int []Array)
{
    int Sum=Array[1];
    int i = 1;
    while  ( i < Array.Length-1)
    {
    i = i+2;
    Sum=Sum + Array[i];   
    }
    return Sum;
}
int Result = GetOddNumbersSum(Array);
Console.WriteLine();
Console.WriteLine($" The Sum of the Numbers in odd positions is {Result}");
