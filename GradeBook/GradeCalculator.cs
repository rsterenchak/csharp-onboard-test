namespace GradeBook;

/// <summary>
/// Pure grade logic — no Console I/O, so it can be unit-tested directly.
/// Keeping logic separate from input/output is what lets `dotnet test`
/// verify correctness in CI (your phone-readable "it works" signal).
/// </summary>
public static class GradeCalculator
{
    /// <summary>Average of a set of grades. Throws on an empty set.</summary>
    public static double Average(IReadOnlyCollection<double> grades)
    {
        if (grades is null || grades.Count == 0)
            throw new ArgumentException("Need at least one grade to average.", nameof(grades));

        double sum = 0;
        foreach (var g in grades) sum += g;
        return sum / grades.Count;
    }

    /// <summary>Letter grade for a numeric score on the usual 90/80/70/60 scale.</summary>
    public static char Letter(double score) => score switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 70 => 'C',
        >= 60 => 'D',
        _     => 'F',
    };
}
