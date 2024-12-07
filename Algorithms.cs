

namespace AlgorithmQuestions
{
    public class Algorithms
    {
        public static List<int> GetVowelPositions(string text)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            List<int> numbers = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (text[i] == vowels[j])
                    {
                        numbers.Add(i);

                    }

                }
            }
            return numbers;
        }



        //    Given a string, you need to return a new string where every letter is shifted to
        // its right by one place in alphabetical order. The last letters 'z' and 'Z' should be
        // replaced with the first ones: 'a' and 'A', respectively. If the character isn't a
        // letter, it should stay the same.
        // It is not allowed to use string built-in methods here.
        // For example, given the string "abc123XYz!", the function should return
        // "bcd123YZa!".

        // public static string ShiftLetters(string inputString)
        // {
            
        // }

        // public static void Print2()
        // {
        //     Console.WriteLine(ShiftLetters("abc123XYZ!"));
        // }

        // public static string ReplaceCharacter(string inputString, char c1, char c2) 
        // {
        //     for(int i = 0;i<inputString.Length;i++)
        //     {
        //         if(inputString[i] == c1)
        //         {
        //             c1 = c2;
        //         }
        //         else
        //         {
        //             
        //         }
        //     }
        // }

        //   string Reverse(string word)
        // {
        //     int i,j = 0;
        //      char[] reversed = new char [word.Length];
        //     for(i = 0; i)
        //      for(i = word.Length - 1; i >= 0; i--)
        //     {
        //         if(word)
        //         reversed[j++] = word[i];
        //      }
        //     return new string(reversed);
        // }  
        // public static string ReplaceCharacter(string inputString, char c1, char c2)
        // {
            
        // }
        public static string SwapPairs(string s)
        {
            string manipulatedString = "";
            for (int i = 0; i < s.Length-1; i+=2)
            {
                char x = s[i];
                char y = s[i + 1];
                manipulatedString += y + x;
            }
            for(int i = 0; i < 1 ; i++)
            {
                if (s.Length / 2 % 2 == 0)
                {
                    manipulatedString += s[s.Length-1];
                }
            }
        
            return new string manipulatedString;
        }

    }
}



//lesson 16
