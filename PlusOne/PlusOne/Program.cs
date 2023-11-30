namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 7, 9, 1 };
            var intList = new List<int>();
            int plusOne = 0;

            if (nums[nums.Length - 1] == 9)
            {
                intList.Add(0);
                plusOne = 1;
            }
            else
            {
                intList.Add(nums[nums.Length - 1] + 1);
            }

            for (int i = nums.Length - 2; i >= 0 ; i--)
            {
                if (nums[i] == 9 && plusOne == 1)
                {
                    intList.Add(0);
                }
                else if (nums[i] != 9 && plusOne == 1)
                {
                    intList.Add(nums[i] + 1);
                    plusOne = 0;
                }
                else
                {
                    intList.Add(nums[i]);
                }
            }

            if( plusOne == 1 )
                intList.Add(1);

            intList.Reverse();
            var a = intList.ToArray();

            Console.WriteLine();
        }
    }
}
