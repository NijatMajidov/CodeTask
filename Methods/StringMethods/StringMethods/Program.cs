namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "   Salam,   Dunya    lorem";
            DelUnneededSpace(str1); //Salam, Dunya lorem

            string str2 = "sAlam123";
            Console.WriteLine("\n"+ checkString(str2)); //True

            string str3 = "  salam ,   bb207   ";
            Console.WriteLine(firstWord(str3)); //salam

            string str4 = "  Salam,     Dunya!  Ilk Iki sozu yoxla"; //True
            Console.WriteLine(TwoWordCheck(str4));

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int newElement = 9;
            Console.WriteLine("\nKohne hal: ");
            foreach (int i in arr) Console.Write(i + ", ");
            Console.WriteLine("\nYeni hal: ");
            Added(ref arr, newElement);
            foreach (int i in arr) Console.Write(i+", ");
            
        }
        #region Task1
        public static void DelUnneededSpace(string str)
        {
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                        Console.Write(str[i+1]);
                }
                else if (str[i] != ' ' && str[i+1] != ' ') Console.Write(str[i + 1]);
                else if (str[i] != ' ' && str[i+1] == ' ') Console.Write(" ");

            }
        }

        #endregion

        #region Task2
        public static bool checkString(string str)
        {
            bool numChck = false;
            bool lowChck = false;
            bool upChck = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9') numChck = true;

                if (str[i] >= 'A' && str[i] <= 'Z') upChck = true;

                if (str[i] >= 'a' && str[i] <= 'z') lowChck = true;

            }

            return numChck && lowChck && upChck;
        }
        #endregion

        #region Task3
        public static string firstWord(string str)
        {
            string first = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') 
                { 
                    first += str[i];

                    if (str[i] != ' ' && str[i + 1] == ' ')  break; 
                }
            }

            return first;
        }
        #endregion

        #region Task4

       public static bool TwoWordCheck(string str)
        {
            string first = "";
            string second = "";
           
            int temp = 0;
            for (int i = temp; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    first += str[i];
                    
                    if (str[i] != ' ' && str[i + 1] == ' ') 
                    { 
                        temp = i; 
                        break; 
                    }
                }
            }
            for (int i = temp+1; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    second += str[i];

                    if (str[i] != ' ' && str[i + 1] == ' ') break;
                }
            }

            bool firstCheck = false;
            bool secondCheck = false;

            if (first[0] >= 'A' && first[0] <= 'Z') firstCheck = true;
            if (second[0] >= 'A' && second[0] <= 'Z') secondCheck = true;

            return firstCheck && secondCheck;
        }
        #endregion

        #region Task5 or Array.Methods
        public static void Added(ref int[] ints, int newValue)
        {
            int[] newArr = new int[ints.Length+1];
            
            for (int i = 0; i < ints.Length; i++)
            {
                newArr[i] = ints[i];
            }

            newArr[newArr.Length-1] = newValue;

            ints = newArr;
            
        }
        #endregion
    }
}
