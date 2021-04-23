using SystemIO
using system;

namespace Day_2
{
class Class10
{
static void Main()
{
Console.WriteLine("Enter a string");
string inputString = Console.ReadLine();//arppu
char []reversedStringArray=new char[inputString.Length];
for(int i= inputString.Length-1; i>=0; i--)
{
reversedStringArray[i] = inputString[i];
}
string reversedString = new string(reversedStringArray);
if(reversedString== inputString)
{
Console.WriteLine("it is a palindrome");
}
else
{
Console.WriteLine("Please re-enter the palindrome");
}
Console.ReadLine();
}
}