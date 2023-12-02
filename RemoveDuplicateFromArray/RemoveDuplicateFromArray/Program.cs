namespace RemoveDuplicateFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int k = 1;
            int pointerValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != pointerValue)
                {
                    nums[k] = nums[i];
                    k++;
                }
                pointerValue = nums[i];
            }

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
