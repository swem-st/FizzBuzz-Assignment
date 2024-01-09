using FizzBuzz_Assignment.DomainModels;

namespace FizzBuzz_AssignmentTests;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void FizzBuzz_ShouldReturnFizz_WhenDivisibleBy3()
    {
        // Arrange
        var fizzAction = new FizzAction();
        var fizzBuzz = new FizzBuzz(new[] { fizzAction });

        // Act
        var result = fizzBuzz.Execute(3);

        // Assert
        Assert.AreEqual("Fizz", result);
    }

    [Test]
    public void FizzBuzz_ShouldReturnBuzz_WhenDivisibleBy5()
    {
        // Arrange
        var buzzAction = new BuzzAction();
        var fizzBuzz = new FizzBuzz(new[] { buzzAction });

        // Act
        var result = fizzBuzz.Execute(5);

        // Assert
        Assert.AreEqual("Buzz", result);
    }

    [Test]
    public void FizzBuzz_ShouldReturnFizzBuzz_WhenDivisibleByBoth3And5()
    {
        // Arrange
        var fizzBuzzAction = new FizzBuzzAction();
        var fizzBuzz = new FizzBuzz(new[] { fizzBuzzAction });

        // Act
        var result = fizzBuzz.Execute(15);

        // Assert
        Assert.AreEqual("FizzBuzz", result);
    }

    [Test]
    public void FizzBuzz_ShouldReturnNumber_WhenNotDivisibleBy3Or5()
    {
        // Arrange
        var standardAction = new StandardAction(7);
        var fizzBuzz = new FizzBuzz(new[] { standardAction });

        // Act
        var result = fizzBuzz.Execute(7);

        // Assert
        Assert.AreEqual("7", result);
    }
}