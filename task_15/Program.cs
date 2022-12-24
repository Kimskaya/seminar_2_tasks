// program which takes a weekday and shows 
//if its a weekend day or not
int GetDayNumber(string message)
{
    Console.WriteLine(message);
    int DayNumber = int.Parse(Console.ReadLine()!);
    return DayNumber;
}
int Day = GetDayNumber("Input Day Number");
    void ChechTheDay (int Day)
    {if (Day <6)
     {
        Console.WriteLine("This is a weekday");
     }
    else if(Day>7)
     {
        Console.WriteLine("Incorrect number");
     }
     else 
        {
            Console.WriteLine("This is a Weekend day");
        }  
    }
    ChechTheDay(Day);