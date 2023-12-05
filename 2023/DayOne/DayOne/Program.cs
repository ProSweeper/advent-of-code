using System.Globalization;
using Microsoft.VisualBasic;

var path = "./input.txt";

string[] test = [
"1abc2",
"pqr3stu8vwx",
"a1b2c3d4e5f",
"treb7uchet"
];
int[] testResults = [12, 38, 15, 77];

string numbers = "1234567890";
string[] lines = File.ReadAllLines(path);
int total = 0;
foreach (string line in lines)
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
		string combinedNum = new string([firstNum, secondNum]);
		int combinedNumber = int.Parse(combinedNum);
		total += combinedNumber;
	}
}
Console.WriteLine(total);
