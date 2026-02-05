using Calculator;

namespace Tests;

public class CachedCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new CachedCalculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calc.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
        int a = 5, b = 2;

        // Act
        int result = calc.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Multiply()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
        int a = 2, b = 2;

        // Act
        int result = calc.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Divide()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
        int a = 6, b = 2;

        // Act
        int result = calc.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Factorial1()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
        int a = 5;

        // Act
        int result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void Factorial2()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
        int a = 0;

        // Act
        int result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
}