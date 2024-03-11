namespace arrayTask
{
   internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 17, 3, 9, 21, 15 };
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("en kicik element: " + min);
        }
    }
}
