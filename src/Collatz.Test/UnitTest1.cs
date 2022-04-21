using NUnit.Framework;
using Collatz;

namespace Collatz.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(8, 20, 20, 4)]
    [TestCase(3, 20, 20, 8)]
    [TestCase(9, 20, 53, 20)]
    public void CollatzReturnsCorrectly(int n, int maxLen, int maxSize, int expect_len)
    {
        Assert.AreEqual(BasicFunctions.Collatz(n, maxLen, maxSize), expect_len);
    }
    
    [Test]
    [TestCase(9, 20, 52, 19)]
    [TestCase(9, 10, 53, 19)]
    public void CollatzFailsOutOfBounds(int n, int maxLen, int maxSize, int expect_len)
    {
        Assert.AreNotEqual(BasicFunctions.Collatz(n, maxLen, maxSize), expect_len);
    }
    
    [Test]
    [TestCase(-9, 20, 53)]
    public void CollatzNeverRuns(int n, int maxLen, int maxSize)
    {
        Assert.LessOrEqual(BasicFunctions.Collatz(n, maxLen, maxSize),0);
    }
    
    [Test]
    [TestCase(3, 20, 20)]
    [TestCase(9, 20, 53)]
    public void CollatzAndCollatzRecReturnEqual(int n, int maxLen, int maxSize)
    {
        Assert.AreEqual(BasicFunctions.Collatz(n, maxLen, maxSize), BasicFunctions.CollatzRec(n, maxLen, maxSize));
    }
    
    
    
}