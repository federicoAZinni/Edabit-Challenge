using System;
using System.Linq;
using System.Collections;

namespace EjeciciosEdabit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        #region Muy Fácil
        //Return the Sum of Two Numbers
        //Create a function that takes two numbers as arguments and returns their sum.

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        //Return the Next Number from the Integer Passed
        //Create a function that takes a number as an argument, increments the number by +1 and returns the result.

        public static int Addition(int num)
        {
            return num + 1;
        }

        //Area of a Triangle
        //Write a function that takes the base and height of a triangle and return its area.
        public static int TriArea(int b, int h)
        {
            return (b * h) / 2;
        }
        #endregion
        #region Fácil
        //Convert Number to Corresponding Month Name
        //Create a function that takes a number(from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
        public static string MonthName(int num)
        {
            switch (num)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }

        //Find the Smallest and Biggest Numbers
        //Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
        public static double[] FindMinMax(double[] values)
        {
            double min = values[0];
            double max = values[0];

            foreach (double value in values)
            {
                if (value > max) max = value;
                if (value < min) min = value;
            }

            return new double[] { min, max };
        }

        // Absolute Sum
        //Take an array of integers(positive or negative or both) and return the sum of the absolute value of each element.

        public static int GetAbsSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) sum = sum + (arr[i] * -1);
                else sum = sum + arr[i];
            }
            return sum;
        }

        #endregion
        #region Intermedio
        //Array of Multiples
        //Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num until the array length reaches length.
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num * (i + 1);
            }
            return multiples;
        }

        //Reverse the Case
        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        public static string ReverseCase(string str)
        {
            char[] charstr = str.ToCharArray();
            string result = "";

            for (int i = 0; i < charstr.Length; i++)
            {
                char a = charstr[i];
                if (char.IsLower(charstr[i])) result += char.ToUpper(a);
                else result += char.ToLower(a);
            }
            return result;
        }

        //Return the Index of All Capital Letters
        //Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.
        public static int[] IndexOfCapitals(string str)
        {
            char[] charstr = str.ToCharArray();

            int index = 0;

            for (int i = 0; i < charstr.Length; i++)
            {
                if (char.IsUpper(charstr[i]))
                {
                    index++;
                }
            }

            int[] result = new int[index];
            int index2 = 0;

            for (int i = 0; i < charstr.Length; i++)
            {
                if (char.IsUpper(charstr[i]))
                {
                    result[index2] = i;
                    index2++;
                }
            }
            return result;
        }
        #endregion
        #region Difícil
        //ReverseAndNot
        //Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
        public static string ReverseAndNot(int i)
        {
            char[] iChar = i.ToString().ToCharArray();

            char[] Revert = iChar.Reverse().ToArray();

            string result = "";

            for (int a = 0; a < (Revert.Length); a++)
            {
                result += Revert[a];
            }
            for (int a = 0; a < (iChar.Length); a++)
            {
                result += iChar[a];
            }
            return result;
        }

        //C*ns*r*d Str*ngs
        //Someone has attempted to censor my strings by replacing every vowel with a*, l* k* th* s.Luckily, I've been able to find the vowels that were removed.
        //Given a censored string and a string of the censored vowels, return the original uncensored string.
        public static string Uncensor(string txt, string vowels)
        {
            char[] txtChar = txt.ToCharArray();
            char[] vowelsChar = vowels.ToCharArray();
            string result = "";
            int index = 0;
            for (int i = 0; i < txtChar.Length; i++)
            {
                if (txtChar[i] == 42)
                {
                    result += vowelsChar[index];
                    index++;
                    continue;
                }
                result += txtChar[i];
            }

            return result;
        }

        //Smooth Sentences
        //Carlos is a huge fan of something he calls smooth sentences.
        //A smooth sentence is one where the last letter of each word is identical to the first letter the following word(and not case sensitive, so "A" would be the same as "a").
        //The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
        //Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.

        public static bool IsSmooth(string sentence)
        {
            string result = sentence.ToLower();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 32)
                {
                    if (result[i - 1] != result[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion
        #region Muy Difícil

        //Fibonacci Word
        //A Fibonacci Word is a specific sequence of binary digits(or symbols from any two-letter alphabet). The Fibonacci Word is formed by repeated concatenation in the same way that the Fibonacci numbers are formed by repeated addition.
        //Create a function that takes a number n as an argument and returns the first n elements of the Fibonacci Word sequence.
        //If n < 2, the function must return "invalid".
        public static string FiboWord(int n)
        {
            if (n < 2) return "invalid";

            string[] result = new string[n];
            result[0] = "b";
            result[1] = "a";

            string final = "";
            

            for (int i = 2; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (i == (result.Length - 1))
                { final += (result[i]); break; }
                final += (result[i]) + ", ";
            }
            return final;
        }


        //New Driving License
        //You have to get a new driver's license. You show up at the office at the same time as four other people. The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. All of the agents are available now, and they can each see one customer at a time. How long will it take for you to walk out with your new license?
        //Your input will be a string of your name me, an integer of the number of available agents, and a string of the other four names separated by spaces others.
        //Return the number of minutes it will take to get your license.

        public static int License(string me, int agents, string others)
        {
            string asd = others + " " + me;

            string[] arrWords = asd.Split(" ");

            Array.Sort(arrWords);

            int indexqueue = 0;

            for (int i = 0; i < arrWords.Length; i++)
            {
                if (arrWords[i] == me) indexqueue = i;
            }

            int result = 20;
            result += (indexqueue / agents) * 20;

            return result;
        }
        #endregion
        #region Experto
        //Kaprekar's Constant
        //6174 is known as one of Kaprekar's constants, after the Indian mathematician D. R. Kaprekar. Number 6174 is notable for the following rule:
        //Take any four-digit number, using at least two different digits(leading zeros are allowed).
        //Arrange the digits in descending and then in ascending order to get two four-digit numbers, adding leading zeros if necessary.
        //Subtract the smaller number from the bigger number.
        //Go back to step 2 and repeat.
        public static int Kaprekar(int num)
        {
            int result = 0;
            int result1 = 0;
            int indexResult = 0;
            string numstring = num.ToString();

            if (numstring == "0000" || numstring == "1111") return 0;

            while (6174 != result)
            {
                char[] rever = numstring.ToCharArray();
                Array.Sort(rever);
                result1 = int.Parse(rever);
                Array.Reverse(rever);
                result = int.Parse(rever);
                result -= result1;
                Math.Abs(result);
                numstring = result.ToString();
                indexResult++;
            }
            return indexResult;
        }

        //Palindrome Descendant
        //A number may not be a palindrome, but its descendant can be.A number's direct child is created by summing each pair of adjacent digits to create the digits of the next number.
        //For instance, 123312 is not a palindrome, but its next child 363 is, where: 3 = 1 + 2; 6 = 3 + 3; 3 = 1 + 2.
        //Create a function that returns true if the number itself is a palindrome or any of its descendants down to the first 2 digit number(a 1-digit number is trivially a palindrome).

        public static bool PalindromeDescendant(int num)
        {
            string result = "";
            char[] numChar = num.ToString().ToCharArray();
            string reverseResultString = "a";

            while (result != reverseResultString)
            {
                for (int i = 0; i < numChar.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            int a = int.Parse(numChar[i-1].ToString());
                            int b = int.Parse(numChar[i].ToString());
                            int resultInt = a + b;
                            result += resultInt.ToString();
                        }
                    }

                char[] reverseResult = result.ToCharArray();
                Array.Reverse(reverseResult);
                reverseResultString = new string(reverseResult);
                numChar = result.ToCharArray();

                if (result == reverseResultString) return true;
                if (reverseResult.Length <= 2) return false;

                result = "";
            }
            return false;
        }
        #endregion
    }
}

