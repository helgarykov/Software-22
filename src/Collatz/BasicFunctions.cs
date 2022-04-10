namespace Collatz;

public class BasicFunctions
{
    /// <summary>
    /// hhhhh
    /// </summary>
    /// <param name="n"></param>
    /// <param name="maxLen"></param>
    /// <param name="maxSize"></param>
    /// <returns> len </returns>
    public int Collatz(int n, int maxLen, int maxSize)
    {
        int len = 0;
        while (n > 1 && len <= maxLen && n < maxSize)
        {
            len++;
            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = 3 * n + 1;
            }
        }
        return len;
    }
}
