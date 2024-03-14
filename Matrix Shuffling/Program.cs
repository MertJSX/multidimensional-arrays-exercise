namespace Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] map = new string[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {

                string[] input = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < size[1]; j++)
                {
                    map[i, j] = input[j];
                }
            }

            while (true)
            {
                string memory = null;
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                if (input.Split()[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int[] shuffleCommand = input
                    .Split()
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();
                try
                {
                    memory = map[shuffleCommand[0],shuffleCommand[1]];

                    map[shuffleCommand[0], shuffleCommand[1]] = map[shuffleCommand[2], shuffleCommand[3]];

                    map[shuffleCommand[2], shuffleCommand[3]] = memory;

                    for (int i = 0; i < size[0]; i++)
                    {
                        for (int j = 0; j < size[1]; j++)
                        {
                            Console.Write($"{map[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
