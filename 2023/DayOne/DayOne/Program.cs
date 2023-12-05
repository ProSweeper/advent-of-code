using System.Globalization;
using Microsoft.VisualBasic;

var path = "./input.txt";

string numbers = "1234567890";
var lines = File.ReadAllLines(path);
int[] values;
foreach (var line in lines)
{
  int firstNumberIndex = -1;
  int secondNumberIndex = -1;

  for (int i = 0; i < line.Length; i++)
  {
    if (numbers.Contains(line[i]))
    {
      if (firstNumberIndex < 0)
      {
        firstNumberIndex = i;
      }
      else
      {
        secondNumberIndex = i;
      }
    }
  }
  if (secondNumberIndex < 0)
  {
    secondNumberIndex = firstNumberIndex;
  }
  if (firstNumberIndex > -1 && secondNumberIndex > -1)
  {
    char firstNum = line[firstNumberIndex];
    char secondNum = line[secondNumberIndex];
    string combinedNum = firstNum + secondNum;
    int combinedNumber = int.Parse(combinedNum);
    values.Append(combinedNumber);
  }
  foreach (var value in values) {
	Console.WriteLine
  }
}
