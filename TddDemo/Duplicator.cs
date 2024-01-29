using System.Text;

namespace TddDemo;

public class Duplicator
{
	private readonly string _input;
	private readonly int _duplicateNumber;

	public Duplicator(string? input, int duplicateNumber)
	{
		ArgumentException.ThrowIfNullOrEmpty(input);

		_input = input;

		if (duplicateNumber < 0)
		{
			throw new ArgumentException("Duplicate number should be positive");
		}

		_duplicateNumber = duplicateNumber;
	}

	public string Duplicate()
	{
		var stringBuilder = new StringBuilder();

		for (var i = 0; i < _duplicateNumber; i++)
			stringBuilder.Append(_input);

		return stringBuilder.ToString();
	}
}