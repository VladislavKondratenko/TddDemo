using TddDemo;

Console.WriteLine("Enter the input string:");
var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
	Console.WriteLine("Input string cannot be empty.");
	return;
}

Console.WriteLine("Enter number of the duplicate:");
var duplicateInput = Console.ReadLine();

if (int.TryParse(duplicateInput, out var duplicateNumber) is false)
{
	Console.WriteLine("Duplicate number should be a number");
	return;
}

if (duplicateNumber < 0)
{
	Console.WriteLine("Duplicate number should be positive");
	return;
}

var duplicator = new Duplicator(input, duplicateNumber);
var result = duplicator.Duplicate();

Console.WriteLine(result);


