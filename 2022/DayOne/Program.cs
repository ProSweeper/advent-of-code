string path = "C:\\Users\\ddoucet\\code\\advent-of-code\\2022\\DayOne\\day1input.txt";

var lines = File.ReadAllLines(path);
int curSum = 0;
int maxSum = 0;
int[] topThreeElves = {0, 0, 0};

// part one
for (int i = 0; i < lines.Length; i++)
{
	var currLine = lines[i];
	if (currLine == "")
	{
		if (curSum > maxSum) 
		{
			maxSum = curSum;
		}
			curSum = 0;
	}
	else 
	{
		curSum += int.Parse(currLine);
	}
}
Console.WriteLine(maxSum);

// part two
for (int i = 0; i < lines.Length; i++)
{
	var currLine = lines[i];
	if (currLine == "")
	{
		if (curSum > topThreeElves[0]) 
		{
			topThreeElves[0] = curSum;
			Array.Sort(topThreeElves);
		}
			curSum = 0;
	}
	else 
	{
		curSum += int.Parse(currLine);
	}
}
Console.WriteLine(topThreeElves.Sum());
