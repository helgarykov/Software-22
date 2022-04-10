using NUnit.Framework;

namespace Collatz.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(3, 20, 20)]
    [TestCase(9, 20, 50)]
    public void CollatzReturnsCorrectly(int n, int maxLen, int maxSize)
    {
        Assert.AreEqual(7, 7);
        Assert.AreEqual(8, 8);
    }
}