using System;

namespace Phone {
    class Program {
       
       static string reverse(string str)
       {
           string str1 = "";
           for (int i = str.Length - 1; i >= 0 ; i--)
          { 
              str1 += str[i];
          }
          return str1; 
       }
       
       public static string[] RemoveEvenLengthStr(string[] arr)
       {
            List<string> Words = new List<string>();
            foreach(string word in arr)
            {
                if(word.Length % 2 == 1)
                {
                    Words.Add(word);
                }
            }
        
            foreach(string word in Words)
            {
                Console.WriteLine(word);
            }
            return Words.ToArray();
       }

       public static string ToRoman(int number)
       {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;            
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900); 
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);            
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
       }
        
            

       public static int RomanToInteger(string roman)
        {
            Dictionary<char, int> RomanMap = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };


            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                    number -= RomanMap[roman[i]];
                }
                else
                {
                    number += RomanMap[roman[i]];
                }
            }
            return number;
        }


       
        static void Main (string[] args)
       {
            Console.WriteLine(reverse("pollosoosos"));
        }
    }
}