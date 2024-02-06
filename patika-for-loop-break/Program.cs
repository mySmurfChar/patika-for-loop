namespace patika_for_loop_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("Enter number of rows: ");
            n=int.Parse(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                int t = n - i;
                for (; t >= 0; t--)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }

        }



        }
    }

