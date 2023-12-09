namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = Convert.ToInt32(Console.ReadLine());
            var resultList = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var newList = new List<int>();
                if (i == 0)
                    newList.Add(1);
                else if (i == 1)
                    newList = new List<int> { 1, 1 };
                else if (i > 1)
                {
                    int[] arr = resultList[i-1].ToArray();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (j == 0)
                            newList.Add(arr[j]);
                        else
                        {
                            newList.Add(arr[j-1] + arr[j]);
                        }
                    }
                    newList.Add(1);
                }
                resultList.Add(newList);

                IList<IList<int>> list = resultList;
            }
            Console.WriteLine(resultList.Count);
        }
    }
}
