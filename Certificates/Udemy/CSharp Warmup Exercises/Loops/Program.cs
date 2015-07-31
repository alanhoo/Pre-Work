using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSharpExercise.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(StringTimes("Hi", 2));
            Console.WriteLine(StringTimes("Hi", 3));
            Console.WriteLine(StringTimes("Hi", 1));
            Console.ReadLine();
            
            Console.WriteLine(FrontTimes("Chocolate", 2));
            Console.WriteLine(FrontTimes("Chocolate", 3));
            Console.WriteLine(FrontTimes("abc", 3));
            Console.ReadLine();
            
            Console.WriteLine(CountXX("abcxx"));
            Console.WriteLine(CountXX("xxx"));
            Console.WriteLine(CountXX("xxxx"));
            Console.ReadLine();
            
            Console.WriteLine(DoubleX("axxbb"));
            Console.WriteLine(DoubleX("axaxaxax"));
            Console.WriteLine(DoubleX("xxxx"));
            Console.ReadLine();
            
            Console.WriteLine(StringSplosion("Code"));
            Console.WriteLine(StringSplosion("abc"));
            Console.WriteLine(StringSplosion("ab"));
            Console.ReadLine();
            
            Console.WriteLine(CountLast2("hixxhi"));
            Console.WriteLine(CountLast2("xaxxaxaxx"));
            Console.WriteLine(CountLast2("axxxaaxx"));
            Console.ReadLine();
            
            int[] numbers = {1,2,9};
            int[] numbers2 = {1,9,9};
            int[] numbers3 = {1,9,9,3,9};
            Console.WriteLine(Count9(numbers));
            Console.WriteLine(Count9(numbers2));
            Console.WriteLine(Count9(numbers3));
            Console.ReadLine();
            
            int[] numbers = { 1, 2, 9,3,4 };
            int[] numbers2 = { 1, 2,3,4, 9 };
            int[] numbers3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(ArrayFront9(numbers));
            Console.WriteLine(ArrayFront9(numbers2));
            Console.WriteLine(ArrayFront9(numbers3));
            Console.ReadLine();
            
            int[] numbers = { 1, 1, 2, 3, 4 };
            int[] numbers2 = { 1, 1, 2, 4, 9 };
            int[] numbers3 = { 1,1,2,1, 2, 3 };
            Console.WriteLine(Array123(numbers));
            Console.WriteLine(Array123(numbers2));
            Console.WriteLine(Array123(numbers3));
            Console.ReadLine();
            
            Console.WriteLine(SubStringMatch("xxcaazz", "xxbaaz"));
            Console.WriteLine(SubStringMatch("abc", "abc"));
            Console.WriteLine(SubStringMatch("abc","axc"));
            Console.ReadLine();
            
            Console.WriteLine(StringX("xxHxix"));
            Console.WriteLine(StringX("abxxxcd"));
            Console.WriteLine(StringX("xabxxxcdx"));
            Console.ReadLine();
            
            Console.WriteLine(AltPairs("kitten"));
            Console.WriteLine(AltPairs("chocolate"));
            Console.WriteLine(AltPairs("CodingHorrorCodingHorror"));
            Console.ReadLine();
            
            Console.WriteLine(DoNotYak("yakpak"));
            Console.WriteLine(DoNotYak("pakyuk"));
            Console.WriteLine(DoNotYak("yak123ylk"));
            Console.ReadLine();
            
            int[] numbers = { 6, 6, 2, 3, 4 };
            int[] numbers2 = { 6, 6, 2, 6, 9 };
            int[] numbers3 = { 6, 7, 2, 6, 6, 7 };
            Console.WriteLine(Array667(numbers));
            Console.WriteLine(Array667(numbers2));
            Console.WriteLine(Array667(numbers3));
            Console.ReadLine();
            
            int[] numbers = { 1,1,2,2,1};
            int[] numbers2 = { 1, 1, 2, 2, 2, 1 };
            int[] numbers3 = { 1, 1, 1, 2, 2, 2, 1 };
            Console.WriteLine(NoTriples(numbers));
            Console.WriteLine(NoTriples(numbers2));
            Console.WriteLine(NoTriples(numbers3));
            Console.ReadLine();
            
            int[] numbers = { 1, 1, 2, 7, 1 };
            int[] numbers2 = { 1, 1, 2, 2, 8, 1 };
            int[] numbers3 = { 3, 8, 2, 2, 2, 2, 1 };
            Console.WriteLine(Pattern51(numbers));
            Console.WriteLine(Pattern51(numbers2));
            Console.WriteLine(Pattern51(numbers3));
            Console.ReadLine();
            */
        }

        static string StringTimes(string str, int n)
        {
            string answer = str;
            for (int i = 1; i < n; i++)
            {
                answer += str;
            }
            return answer;
        }

        static string FrontTimes(string str, int n)
        {
            str = str.Substring(0, 3);
            string answer = str;
            for (int i = 1; i < n; i++)
            {
                answer += str;
            }
            return answer;
        }

        static int CountXX(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x' && str[i + 1] == 'x')
                    count++;
            }
            return count;
        }

        static bool DoubleX(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x')
                {
                    if (str[i + 1] == 'x')
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        static string StringSplosion(string str)
        {
            string answer = "";
            string accumulator = "";

            for (int i = 0; i < str.Length; i++)
            {
                accumulator += str[i];
                answer += accumulator;
            }

            return answer;
        }

        static int CountLast2(string str)
        {
            string Last2 = str.Substring(str.Length - 2, 2);
            int count = 0;
            for (int i = 0; i < str.Length-2; i++)
            {
                if(str.Substring(i,2) == Last2)
                    count ++;
            }
            return count;
        }

        static int Count9(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                    count++;
            }
            return count;
        }

        static bool ArrayFront9(int[] numbers)
        {
            int len = numbers.Length;

            if (len > 4)
                len = 4;

            for (int i = 0; i < len; i++)
            {
                if (numbers[i] == 9)
                    return true;
            }
            return false;
        }

        static bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                    return true;
            }
            return false;
        }

        static int SubStringMatch(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int k = 0; k < b.Length-1; k++)
                {
                    if (a.Substring(i, 2) == b.Substring(k, 2))
                        count++;
                }
            }
            return count;
        }

        static string StringX(string str)
        {
            string answer = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == str.Length-1 || str[i] != 'x')
                    answer += str[i];              
            }
            return answer;
        }

        static string AltPairs(string str)
        {
            string answer = "";
            for (int i = 0; i < str.Length; i+=4)
            {
                answer += str[i];
                if (i != str.Length - 1)
                    answer += str[i + 1];
            }
            return answer;
        }

        static string DoNotYak(string str)
        {
            //string new_string;
            int i = 0;
            do
            {
                if ((str[i] == 'y' || str[i] == 'Y' )&& (str[i + 2] == 'k' || str[i + 2] == 'K'))
                    str = str.Remove(i, 3);
                i++;
            } while (i < str.Length-2);
            return str;
        }

        static int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                    count++;
            }
            return count;
        }

        static bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                    return false;
            }
            return true;
        }

        static bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 5 && numbers[i + 2] == numbers[i] - 1)
                    return true;
            }
            return false;
        }
    }
}
