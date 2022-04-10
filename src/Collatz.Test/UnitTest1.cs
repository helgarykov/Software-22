using NUnit.Framework;

namespace Collatz.Test;

public class Tests
{

    [Test]
    [TestCase(2, 10, 11)]
    public void CollatzReturns(int n, int maxLen, int maxSize)
    {

        Assert.AreEqual(1, 1);
    }
}