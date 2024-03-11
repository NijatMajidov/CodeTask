namespace ArrayTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String array'imiz var, console'dan (Console.ReadLine()) aldığımız index dəyərinə uyğun gələn elementi tərsinə yazdırın.
            //Məsələn, {"Yusif", "Rəsul", "Ənvər"} verilib, console'dan 2 daxil edilibsə
            //(daxil edilən rəqəmi int'ə çevirməyi araşdırın), ekrana "rəvnƏ" yazılsın.

            string[] names = { "Yusif", "Resul", "Enver" };
            int index = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < names.Length; i++)
            {
                if(i== index)
                {
                    for(int j =names[i].Length-1 ; j >=0 ; j--) {

                        Console.Write(names[i][j]);

                    }
                }
                
            }




        }
    }
}
