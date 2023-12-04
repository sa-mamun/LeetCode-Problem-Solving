namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxArea = 0;
            int localMaxArea = 0;
            int i = 0;
            int j = height.Length - 1;

            while ( i < j)
            {
                if (height[i] < height[j])
                {
                    localMaxArea = height[i] * (j - i);
                    i++;
                }
                else
                {
                    localMaxArea = height[j] * (j - i);
                    j--;
                }

                if (localMaxArea > maxArea)
                    maxArea = localMaxArea;
            }

            Console.WriteLine(maxArea.ToString());
        }
    }
}
