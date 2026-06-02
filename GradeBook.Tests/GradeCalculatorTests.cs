using GradeBook;
using Xunit;

namespace GradeBook.Tests;

public class GradeCalculatorTests
{
    [Fact]
    public void Average_OfKnownSet_IsCorrect()
    {
        var result = GradeCalculator.Average(new[] { 90.0, 80.0, 100.0 });
        Assert.Equal(90.0, result, precision: 5);
    }

    [Fact]
    public void Average_OfEmptySet_Throws()
    {
        Assert.Throws<ArgumentException>(() => GradeCalculator.Average(Array.Empty<double>()));
    }

    [Theory]
    [InlineData(95, 'A')]
    [InlineData(85, 'B')]
    [InlineData(72, 'C')]
    [InlineData(61, 'D')]
    [InlineData(40, 'F')]
    public void Letter_MapsScoreToExpectedGrade(double score, char expected)
    {
        Assert.Equal(expected, GradeCalculator.Letter(score));
    }
}
