# C# Kata Environment

This is a simple kata environment for technical interviews using C# and xUnit.

## Structure

- `Kata.cs` - Implementation file where you write your solutions
- `KataTests.cs` - Test file with test cases to verify your solutions

## Getting Started

1. Open `Kata.cs` and implement the methods marked with `TODO`
2. Run the tests to check your solutions

## Running Tests

### Run all tests

```powershell
dotnet test
```

### Run tests with verbose output

```powershell
dotnet test --logger "console;verbosity=detailed"
```

### Watch mode (auto-run tests on file changes)

```powershell
dotnet watch test
```

## Example Katas

1. **Add** - Sum two numbers
2. **IsPalindrome** - Check if a string is a palindrome (ignoring case and spaces)
3. **Factorial** - Calculate the factorial of a number

## Tips

- Start simple and make one test pass at a time
- Read the test cases to understand the requirements
- Use the test output to guide your implementation
