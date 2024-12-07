/*Write a function that takes a string s, iterates through it, and collects all 0-
based positions of vowels in it to a list*/
namespace AlgorithmQ1
{

    public class Algorithm2
    {

        public static void Print()
        {
            string test = "Hello Word";
            List<int> vowelPositions = GetVowelPositions(test);
            string finalresult ="";
            for(int i = 0; i < results.Count; i++)
            {
                finalResult += results[i] + ",";
            }
            Console.WriteLine($"Vowel: {finalResult} ");
        }
        public static List<int> GetVowelPositions(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<int> GetVowelPositions = new List<int>();
            for (int i = 0; i < s.Length; i++)
             {
                foreach (char vowel in vowels)
                {
                    if (s[i] == vowel)
                    {
                        GetVowelPositions.Add(i);
                    }
                }
            }
            return GetVowelPositions;
        }

         public static void GetShiftLetters()
        {
        string input = "Hello World! Zebra";
        string shiftedString = ShiftLetters(input);
        Console.WriteLine(shiftedString);
       }


        public static string TransformCase(string inputString)
    {
        char[] result = new char[inputString.Length];

        for (int i = 0; i < inputString.Length; i++)
        {
            char c = inputString[i];

            if (c >= 'a' && c <= 'z')
            {
                result[i] = (char)(c - 'a' + 'A'); 
            }
            else if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)(c - 'A' + 'a'); 
            }
            else
            {
                result[i] = c; 
            }
        }

        return new string(result);
    }

    }

      public static string ReplaceCharacter(string inputString, char c1, char c2)
    {
        char[] result = new char[inputString.Length];

        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == c1)
            {
                result[i] = c2;
            }
            else
            {
                result[i] = inputString[i];
            }
        }

        return new string(result);
    }
}