namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temporary = 0;
            int[] nums = {1, 6, 4, 7, 8};

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1] )
                    {
                        temporary = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temporary;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}");
            }
        }
    }
}
