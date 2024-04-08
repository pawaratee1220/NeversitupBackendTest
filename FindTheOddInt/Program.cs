namespace FindTheOddInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter int (Example 1,2,3,4)");
                int[] intArray = Console.ReadLine().Split(",").Select(x => Convert.ToInt32(x)).ToArray();
                Console.WriteLine("Result = " + GetOddOccurrence(intArray, intArray.Length));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static int GetOddOccurrence(int[] arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++)
            {
                int count = 0;
                for (int j = 0; j < arr_size; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count % 2 != 0)
                    return arr[i];
            }
            return -1;
        }
    }
}