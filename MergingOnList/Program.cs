namespace MergingOnList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] lists = input.Split('|');
            List<int> result = new List<int>();

            for (int i = lists.Length - 1; i >= 0; i--)
            {
                
                string[] elements = lists[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string element in elements)
                {
                    
                    result.Add(int.Parse(element));
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
