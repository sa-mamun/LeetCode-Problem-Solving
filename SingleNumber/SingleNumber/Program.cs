namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            int result = 0;
            if (nums.Length > 1)
            {
                var nList = nums.ToList();
                nList.Sort();
                nums = nList.ToArray();
                int a = nums[0];
                int j = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (i + 1 < nums.Length && i != j && a == nums[i])
                    {
                        a = nums[i+1];
                    }
                }
            }
            else
            {
                result = nums[0];
            }

            Console.WriteLine(result);
        }
    }
}
