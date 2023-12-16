namespace ContainsDuplicate_UsingDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool hasDuplicate = false;
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    int val = dic[nums[i]];
                    dic[nums[i]] = val + 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            foreach (var item in dic)
            {
                if (item.Value > 1)
                {
                    hasDuplicate = true;
                    break;
                }
            }

            Console.WriteLine(hasDuplicate);
        }
    }
}
