namespace _2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] map = new string[size[0], size[1]];

            int sum = 0;

            for (int i = 0; i < size[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < size[1]; j++)
                {
                    map[i, j] = input[j];
                }
            }

            for (int i = 1; i < size[0]; i++)
            {
                for (int j = 1; j < size[1]; j++)
                {
                    if (map[i, j] != map[i - 1, j - 1])
                    {
                        continue;
                    }
                    if (map[i, j] != map[i - 1, j])
                    {
                        continue;
                    }
                    if (map[i, j] != map[i, j - 1])
                    {
                        continue;
                    }

                    sum++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}