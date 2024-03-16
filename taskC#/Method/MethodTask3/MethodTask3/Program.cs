namespace MethodTask3
{
    internal class Program
    {
        //Array-in içerisinde verilmiş A herfi ile başlayan elementleri ekrana yazdıran method
        // (example : {"Anar" , "Eli" , "Yusif" , "Arif" } ==> Anar , Arif)
        static void Main(string[] args)
        {
            string[] names = { "Anar", "EliA", "Yusif", "Arif", "aBA" };
            Find_A(names);

        }

        public static void Find_A(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i][0] == 'A')
                {
                    Console.Write(words[i]+" ");
                }

            }
        }

    }
}
