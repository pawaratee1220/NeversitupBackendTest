namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter character : ");
                string input = Console.ReadLine();
                List<string> output = new List<string>();
                Console.Write("\nAll possible strings are : ");
                Permute(input, 0, input.Length - 1, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Permute(string input, int l, int r, List<string> output)
        {
            if (l == r)
            {
                if (!output.Contains(input))
                {
                    output.Add(input);
                    Console.Write(input + " ");
                    return;
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    input = Swap(input, l, i);
                    Permute(input, l + 1, r, output);
                    input = Swap(input, l, i);
                }
            }
        }
        public static string Swap(string input, int i, int j)
        {
            char temp;
            char[] charArray = input.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
            //comment
        }
    }
}