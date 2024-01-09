# FizzBuzz Assignment

This repository showcases a straightforward C# solution to the classic FizzBuzz problem. The implementation focuses on simplicity without using architectural patterns or splitting into layers.

## Problem Description

The program tackles the FizzBuzz problem for a range of numbers (1 to 100), with the following rules:

- If divisible by 3, output "Fizz" instead of the number.
- If divisible by 5, output "Buzz" instead of the number.
- If divisible by both 3 and 5, output "FizzBuzz."
- If none of the above conditions are met, output the number itself.

## Project Structure

The solution follows a basic design, emphasizing a clean and effective implementation without complex architectural patterns or layering.

## Implementation

The core logic resides in the `FizzBuzz` class, employing various rules represented by classes implementing the `IFizzBuzzRule` interface. Each rule checks a specific condition and returns the corresponding result.

## Running the Code

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the program.
4. View the FizzBuzz results in the console for the range 1 to 100.

## Running Tests

Unit tests ensure the correctness of the implementation:

1. Open the test project in Visual Studio.
2. Build the test project.
3. Run tests using a test runner (e.g., NUnit Test Explorer).

Feel free to explore and adapt this simple FizzBuzz solution!
