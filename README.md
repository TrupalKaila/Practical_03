# Practical 04

This practical focuses on looping, switch pattern matching, and static members in C#. It implements a `Student` class to capture marks, calculate aggregates, and report results based on a menu-driven user choice.

## Description

Create a class `Student` that has:

- Public string `Name`
- Public decimal array `Marks[5]`
- A static variable `AverageMarks`
- A method `decimal CalculateAverageMarks()` that calculates the average marks of the student
- A method `string CalculateGrade(decimal marks)` that takes marks and decides a grade based on pattern matching with `switch`
- An enum `Options`:

```
Aggregate = 1,
MinMark = 2,
MaximumMark = 3,
Grade = 4
```

In `Main`:

- Declare `Student`, initialize it by taking input from the user (display proper messages).
- Create a menu for the user to choose from:
  1. Aggregate: Displays `Name` and average marks
  2. MinMark: Displays the minimum mark of the student
  3. MaximumMark: Displays the maximum mark
  4. Grade: Displays grade

Grade thresholds:

- > 90 = A
- > 80 = B
- > 70 = C
- <= 70 = D

If the option is invalid, print `Wrong option chosen`. Compare the input by the user to the enum value and use switch pattern matching.

## How to Run

From the repository root:

```bash
dotnet run --project Practical_04/Practical_04.csproj
```

Follow the prompts to enter the student's name, five marks, and then select a menu option.
