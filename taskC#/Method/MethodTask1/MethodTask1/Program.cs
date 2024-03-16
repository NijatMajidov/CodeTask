namespace MethodTask1
{
    internal class Program
    {
        //2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod;
        static void Main(string[] args)
        {
            string[] strings1 = { "salam", "sagol","ferqli","soz","ler" };
            string[] strings2 = {"salam","necesen", "sagol", "gotur","soz","ler", "eyni","olsa"};

            Same_Elements(strings1,strings2);
        }

        public static void Same_Elements(string[] one, string[] two)
        {
            for(int i = 0; i < one.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {
                    if (one[i] == two[j])
                    {
                        Console.Write(two[j]+" ");
                    }
                }
            }
        }
    }
}
