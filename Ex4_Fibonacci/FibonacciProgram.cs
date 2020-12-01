public class Fibonacci
{
    int numElements;

    public Fibonacci(int numElements)
    {
        this.numElements = numElements;
    }

    public int[] getFibonacci() 
    {
        if (numElements > 0)
        {
            int[] fibonacci = new int[numElements];
            if (numElements > 2) 
            {
                fibonacci[0] = 1;
                fibonacci[1] = 1;
                for (int i = 2; i < numElements; i++)
                {
                    fibonacci[i] = fibonacci[i-2] + fibonacci[i-1];
                }
            }
            else
            {
                if (numElements == 2)
                {
                    fibonacci[0] = 1;
                    fibonacci[1] = 1;
                }
                else
                {
                    fibonacci[0] = 1;
                }
            }
            return fibonacci;
        }
        return new int[0];
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int numElements = 10;
        Fibonacci fibonacci = new Fibonacci(numElements);
        int[] fiboResult = fibonacci.getFibonacci();
        Console.WriteLine("Sequência fibonacci de '" + numElements + "' é:");
        for (int i = 0; i < fiboResult.Length; i++) 
        {
            Console.Write(fiboResult[i] + " ");
        }
    }
}