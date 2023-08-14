namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = M; i <= N; i++)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}.", M, N, sum);

            Console.ReadLine();
        }
    }
}