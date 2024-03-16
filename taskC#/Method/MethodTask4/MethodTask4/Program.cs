namespace MethodTask4
{
    internal class Program
    {
        //Bir ədədi parametr kimi qəbul edib, o ədədə qədər Fibonacci seriyasını bir siyahı kimi qaytaran bir metod yazın.
        static void Main(string[] args)
        {
            int number = 20;

            Console.WriteLine($"{number}'e qeder olan Fibonacci siyahısı: "+ Fibonacci(number));          
        }

        public static string Fibonacci(int n)
        {

            string fibonacci = "";
            int a = 0, b = 1, temp=a;

            for (int i = 0; i < n; i++)
            {
                 fibonacci += a + " ";
                 temp = a;
                 a = b;
                if (b  >= n)
                {

                    break;
                }
                b = temp + b;
            }
            return fibonacci;
        }
    }
}
