namespace Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] map = new int[size[0], size[1]];
            int[,] maximalCombination = new int[3, 3];
            int maxSum = 0;

            for (int i = 0; i < size[0]; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    map[i, j] = input[j];
                }
            }

            for (int i = 2; i < size[0]; i++)
            {
                for (int j = 2; j < size[1]; j++)
                {
                    int sum =
                        map[i, j] +
                        map[i, j - 1] +
                        map[i - 1, j] +
                        map[i - 1, j - 1] +
                        map[i - 2, j - 2] +
                        map[i - 2, j] +
                        map[i, j - 2] +
                        map[i - 1, j - 2] +
                        map[i - 2, j - 1];
                    if (i == 2 && j == 2)
                    {
                        maxSum = sum;
                        for (int k = 2; k >= 0; k--)
                        {
                            int row = i - k;
                            for (int i1 = 2; i1 >= 0; i1--)
                            {
                                int col = j - i1;
                                maximalCombination[k, i1] = map[row, col];
                            }
                        }
                        continue;
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        for (int k = 2; k >= 0; k--)
                        {
                            int row = i - k;
                            for (int i1 = 2; i1 >= 0; i1--)
                            {
                                int col = j - i1;
                                maximalCombination[k, i1] = map[row, col];
                            }
                        }
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 2; i >= 0; i--)
            {
                for (int j = 2; j >= 0; j--)
                {
                    Console.Write($"{maximalCombination[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}