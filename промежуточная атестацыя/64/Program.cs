class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNumbers(N);

        Console.ReadKey();
    }

    static void PrintNumbers(int n)
    {
        if (n < 1)
            return;

        Console.Write(n + " ");

        PrintNumbers(n - 1);
    }
}
