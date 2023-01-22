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


