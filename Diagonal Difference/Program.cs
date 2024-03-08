namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] map = new int[size,size];

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    map[i, j] = int.Parse(input[j]);
                }
            }

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    firstDiagonalSum = map[i, i];
                    secondDiagonalSum = map[size - (1 + i), i];
                } else
                {
                    firstDiagonalSum += map[i, i];
                    secondDiagonalSum += map[size - (1 + i), i];
                }
            }

            int answer = Math.Abs(firstDiagonalSum - secondDiagonalSum);

            Console.WriteLine(answer);


        }
    }
}