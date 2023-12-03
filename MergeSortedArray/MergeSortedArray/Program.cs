namespace MergeSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4,5,6,0,0,0 };
            int[] nums2 = {1,2,3};
            int m = 3;
            int n = 3;
            int j = 0;
            
            int length = m + n;

            if (n != 0 && length > n)
            {
                for (int i = m; i < length; i++)
                {
                    nums1[i] = nums2[j];
                    j++;
                }

                for (int i = 0; i < length; i++)
                {
                    int min = nums1[i];
                    for (int l = i+1; l < length; l++)
                    {
                        if (nums1[l] < min)
                        {
                            int temp = min;
                            min = nums1[l];
                            nums1[l] = temp;
                        }
                    }
                    nums1[i] = min;
                }
            }
            else if (m < n)
            {
                for (int i = 0;i < length;i++)
                {
                    nums1[i] = nums2[j];
                    j++;
                }
            }

            foreach (int i in nums1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
