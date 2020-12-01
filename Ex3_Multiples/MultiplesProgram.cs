public class MultipleAdder
{
    int limit;

    public MultipleAdder(int limit)
    {
        this.limit = limit;
    }

    public int getSum() 
    {
        int sum = 0;
        for (int i = 1; i <= limit; i++)
        {
            if (i%3 == 0 && i%5 == 0) 
            {
                sum += i;
            }
        }
        return sum;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int limit = 100;
        MultipleAdder multipleAdder = new MultipleAdder(limit);
        Console.Write("Soma dos números múltiplos de 3 e 5 até '" + limit + "' é: " + multipleAdder.getSum());
    }
}