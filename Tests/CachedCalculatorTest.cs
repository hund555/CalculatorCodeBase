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

    [Test]
    public void Factorial3()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
        int a = -1;

        // Act & assert
        var ex = Assert.Throws<ArgumentException>(() => calc.Factorial(a));
    }

    [Test]
    public void IsPrime()
    {
        // Arrange
        ICalculator calc = new CachedCalculator();
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
        ICalculator calc = new CachedCalculator();
        int a = 9;

        // Act
        bool result = calc.IsPrime(a);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Add_CachedResult()
    {
        // Arrange
        var calc = new CachedCalculator();
        int a = 2;
        int b = 3;

        // Act
        int result1 = calc.Add(a, b);
        int result2 = calc.Add(a, b); // This should hit the cache

        // Assert
        Assert.That(result1, Is.EqualTo(5));
        Assert.That(result2, Is.EqualTo(5));
        Assert.That(calc._cache.Count, Is.EqualTo(1)); // Ensure only one entry in cache
    }

    [Test]
    public void Factorial_CachedResult()
    {
        // Arrange
        var calc = new CachedCalculator();
        int a = 5;

        // Act
        var result1 = calc.Factorial(a);
        var result2 = calc.Factorial(a); // This should hit the cache

        // Assert
        Assert.That(result1, Is.EqualTo(120));
        Assert.That(result2, Is.EqualTo(120));
        Assert.That(calc._cache.Count, Is.EqualTo(1)); // Ensure only one entry in cache
    }

    [Test]
    public void IsPrime_CachedResult()
    {
        var calc = new CachedCalculator();
        int a = 17;
        // Act

        bool result1 = calc.IsPrime(a);
        bool result2 = calc.IsPrime(a); // This should hit the cache

        // Assert
        Assert.That(result1, Is.True);
        Assert.That(result2, Is.True);
        Assert.That(calc._cache.Count, Is.EqualTo(1)); // Ensure only one entry in cache
    }

    [Test]
    public void Subtract_CachedResult()
    {
        // Arrange
        var calc = new CachedCalculator();
        int a = 5;
        int b = 2;

        // Act
        int result1 = calc.Subtract(a, b);
        int result2 = calc.Subtract(a, b); // This should hit the cache

        // Assert
        Assert.That(result1, Is.EqualTo(3));
        Assert.That(result2, Is.EqualTo(3));
        Assert.That(calc._cache.Count, Is.EqualTo(1)); // Ensure only one entry in cache
    }

    [Test]
    public void Multiply_CachedResult() 
    {
        var calc = new CachedCalculator();
        int a = 2;
        int b = 2;

        // Act
        int result1 = calc.Multiply(a, b);
        int result2 = calc.Multiply(a, b); // This should hit the cache

        // Assert
        Assert.That(result1, Is.EqualTo(4));
        Assert.That(result2, Is.EqualTo(4));
        Assert.That(calc._cache.Count, Is.EqualTo(1)); // Ensure only one entry in cache
    }
}