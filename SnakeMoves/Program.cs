namespace SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string snake = Console.ReadLine();

            char[,] map = new char[size[0], size[1]];

            string position = "left";

            int charIndex = 0;

            for (int i = 0; i < size[0]; i++)
            {
                if (position == "left")
                {
                    for (int j = 0; j < size[1]; j++)
                    {
                        
                        map[i, j] = snake[charIndex];

                        if (charIndex >= snake.Length - 1)
                        {
                            charIndex = 0;
                        }
                        else
                        {
                                charIndex++;
                            
                        }
                        
                    }
                } 
                else
                {
                    for (int j = size[1]; j > 0; j--)
                    {
                        
                        map[i, j - 1] = snake[charIndex];


                        if (charIndex >= snake.Length - 1)
                        {
                            charIndex = 0;
                        }
                        else
                        {

                                charIndex++;

                        }

                    }
                }
                
                    
                if (position == "left")
                {
                    position = "right";
                } 
                else
                {
                    position = "left";
                }
            }

            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
