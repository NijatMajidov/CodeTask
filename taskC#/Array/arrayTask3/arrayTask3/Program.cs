namespace arrayTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2, 3,4, -5 };
            int len = array.Length;
            int[] newArr = new int[len];

            for(int i = len-1; i >=0; i--) {

                if (array[i] < 0) {
                    array[i] *= -1;
                }
                newArr[i] = array[i];

                Console.Write(newArr[i] + " ");
            }
            
        }
    }
}
