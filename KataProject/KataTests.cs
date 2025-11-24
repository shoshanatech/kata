namespace KataProject;

/// <summary>
/// Tests for the Kata exercises
/// Run tests with: dotnet test
/// </summary>
public class KataTests
{
	[Theory]
	[InlineData(2, new int[] { 2 })]
	[InlineData(3, new int[] { 3 })]
	[InlineData(4, new int[] { 2, 2 })]

	public void ShouldReturnPrimeFactors(int n, int[] expected)
	{
		Assert.Equal(expected, Kata.Answer(n));
	}
}
