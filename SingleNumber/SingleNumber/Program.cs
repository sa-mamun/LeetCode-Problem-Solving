namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 2, 3, 3, 4, 5, 5, 1, 1};
            int result = 0;
            if (nums.Length > 1)
            {
                var nList = nums.ToList();
                nList.Sort();
                nums = nList.ToArray();
                result = nums[0];
                int found = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (result == nums[i])
                    {
                        found++;
                    }
                    else if (result != nums[i] && found > 0)
                    {
                        result = nums[i];
                        found = 0;
                    }
                    else if (result != nums[i] && found == 0)
                    {
                        break;
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
