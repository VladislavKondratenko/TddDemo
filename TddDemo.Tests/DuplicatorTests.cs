namespace TddDemo.Tests;

public class DuplicatorTests
{
	[Theory(DisplayName = "Should return duplicated string certain times")]
	[InlineData("a", 3, "aaa")]
	[InlineData("b", 2, "bb")]
	[InlineData("Fuck", 4, "FuckFuckFuckFuck")]
	public void PositiveTestCase(string input, int dupValue, string expected)
	{
		//Arrange
		var duplicator = new Duplicator(input, dupValue);

		//Act
		var result = duplicator.Duplicate();
		
		//Assert
		Assert.Equal(expected, result);
	}

	[Theory(DisplayName = "Should throw an exception if it is invalid")]
	[InlineData(null, 2)]
	[InlineData("", 3)]
	[InlineData("asd", -1)]
	public void NegativeTestCases(string input, int dupValue)
	{
		Assert.ThrowsAny<ArgumentException>(() => new Duplicator(input, dupValue));
	}
}