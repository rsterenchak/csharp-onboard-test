# GradeBook — console-shape onboarding test repo

A throwaway C#/.NET console app used to verify the Claude routine's **console shape**
onboarding end to end. Not real coursework — a smoke test.

## What it is

- `GradeBook/` — a .NET 8 console app. `GradeCalculator.cs` holds pure, testable
  logic (average + letter grade); `Program.cs` is a thin Console shell around it.
  This is the separable-logic pattern that makes CI tests a real confidence signal.
- `GradeBook.Tests/` — xUnit tests for the calculator logic.

## What it's testing

Onboarding this repo via `onboard.sh` should:
1. Detect the **console** shape (from `GradeBook.sln` / the `.csproj` files).
2. Scaffold the routine files + a `dotnet` test workflow (`test.yml`), and NOT
   scaffold any manifest generators or deploy/manifest workflows.
3. On first push, CI should: build (Release), detect the test project, run
   `dotnet test`, and pass.

If the CI run goes green with the test step actually executing (not skipped),
the console shape is proven.

## Run locally

```bash
dotnet test            # run the tests
dotnet run --project GradeBook            # demo run with built-in grades
dotnet run --project GradeBook -- 95 88 72   # pass your own grades
```
