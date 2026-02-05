using Calculator;

namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        // Arrange
        var calc = new SimpleCalculator();
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
        ICalculator calc = new SimpleCalculator();
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
        ICalculator calc = new SimpleCalculator();
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
        ICalculator calc = new SimpleCalculator();
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
        ICalculator calc = new SimpleCalculator();
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
        ICalculator calc = new SimpleCalculator();
        int a = 0;

        // Act
        int result = calc.Factorial(a);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Factorial3()
    {
        // Arrange
        ICalculator calc = new SimpleCalculator();
        int a = -1;

        // Act & assert
        var ex = Assert.Throws<ArgumentException>(() => calc.Factorial(a));
    }

    [Test]
    public void IsPrime()
    {
        // Arrange
        ICalculator calc = new SimpleCalculator();
        int a = 17;

        // Act
        bool result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsNotPrime()
    {
        // Arrange
        ICalculator calc = new SimpleCalculator();
        int a = 9;

        // Act
        bool result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.False);
    }
}