namespace RemoveNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastNumber = nums[nums.Count - 1];
            while (nums.Contains(lastNumber))
            {
                nums.Remove(lastNumber);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
