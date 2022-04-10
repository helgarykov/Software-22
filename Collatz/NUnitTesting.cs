using NUnit.Framework;

namespace Collatz;

public class Tests
{

    [Test]
    public int CollatzReturns()
    {
        int lenAxpected = 10;
        int lenActual = CollatzReturns(2, 10, 11);
        Assert.True(10; lenActual);
    }
}