using GradeBook;

// Thin I/O shell: read grades from args (or use a demo set), then print
// results using the testable GradeCalculator logic.
var grades = args.Length > 0
    ? args.Select(double.Parse).ToList()
    : new List<double> { 92, 81, 73, 88, 64 };

double avg = GradeCalculator.Average(grades);
Console.WriteLine($"Grades:  {string.Join(", ", grades)}");
Console.WriteLine($"Average: {avg:F1} ({GradeCalculator.Letter(avg)})");
