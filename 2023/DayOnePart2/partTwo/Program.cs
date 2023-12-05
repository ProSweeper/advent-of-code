string[] example = [
	"two1nine",
	"eightwothree",
	"abcone2threexyz",
	"xtwone3four",
	"4nineeightseven2",
	"zoneight234",
	"7pqrstsixteen",
];

string numbers = "1234567890";

static void findNumbers(string input)
{
	string[] numberList = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",];
	foreach (string num in numberList)
	{
		if (input.Contains(num))
		{
			Console.WriteLine(num);
			Console.WriteLine(Array.IndexOf(numberList, num));
		}
	}
}


findNumbers(example[0]);