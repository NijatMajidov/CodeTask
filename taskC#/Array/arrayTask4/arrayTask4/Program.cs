
namespace arrayTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2, 3, 4, -5 };

            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    result += array[i];
                }
                else
                {
                    result += " " + array[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
