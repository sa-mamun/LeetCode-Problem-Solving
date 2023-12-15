namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            double maxLength = nums.Length/2;

            var intList = nums.ToList();
            intList.Sort();
            nums = intList.ToArray();

            int element = nums[0];
            int result = element;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (element == nums[i])
                {
                    count++;
                }
                else
                {
                    element = nums[i];
                    count = 1;
                }

                if (count > maxLength)
                    result = element;
            }

            Console.WriteLine(result);
        }
    }
}
