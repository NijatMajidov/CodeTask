namespace MethodTask2
{
    internal class Program
    {
        //array içerisindeki elementlerin hasilini tapib ekrana yazdiran metod
        static void Main(string[] args)
        {
            int[] arr = { 2, 5,  10, 12 };
            Result(arr);
        }

        public static void Result(int[] arr) {
            int res = 1;
            for (int i=0;i<arr.Length;i++)
            {
                res *= arr[i];
            }
            Console.WriteLine(res);
        }
    }
}
