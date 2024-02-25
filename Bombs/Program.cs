namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split();
            List<int> numbers = inputNumbers.Take(inputNumbers.Length - 2).Select(int.Parse).ToList();
            int bombNum = int.Parse(inputNumbers[inputNumbers.Length - 2]);
            int power = Math.Abs(int.Parse(inputNumbers[inputNumbers.Length - 1]));

           
            if (numbers.Count == 0)
            {
                Console.WriteLine("Molq vuvedi chislo.");
                return;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                    int start = Math.Max(0, i - power);
                    int finish = Math.Min(numbers.Count - 1, i + power);

                    for (int j = finish; j >= start; j--)
                    {
                        numbers.RemoveAt(j);
                    }
                    i = Math.Max(-1, i - power - 1); 
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
