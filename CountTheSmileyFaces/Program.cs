namespace CountTheSmileyFaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter smiley faces (Example :),;(, ;}, :-D)");
                string[] strArray = Console.ReadLine().Split(",").ToArray();
                Console.WriteLine("Result = " + CountSmileys(strArray));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static int CountSmileys(string[] arr)
        {
            int count = 0;

            foreach (string str in arr)
            {
                if (str.Contains(")") || str.Contains("D"))
                {
                    if (str.Contains(":") || str.Contains(";"))
                    {
                        if (str.Length == 2)
                        {
                            count++;
                        }
                        if (str.Length > 2)
                        {
                            if (str.Contains("-") || str.Contains("~"))
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}