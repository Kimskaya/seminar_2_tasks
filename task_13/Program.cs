//Program, which takes a number and shows 
//the third digit of the number
int GetUserNumber(string message)
{
    Console.WriteLine(message);
    int AnyNumber = int.Parse(Console.ReadLine()!); 
    return AnyNumber;
}
int AnyNumber= GetUserNumber("Input any number");
if (AnyNumber<100)
{
    Console.WriteLine( "There is no third digit");
}

int Get3DigitNumber(int AnyNumber)
   {
          while (AnyNumber>999)
         {
           AnyNumber = AnyNumber/10;
         } 
           int result = AnyNumber%10;
        return result;
   }
     int ThreeDigitNumber = Get3DigitNumber(AnyNumber);
    Console.WriteLine($" The third digit is {ThreeDigitNumber}");   