using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CSharp_Exercises.array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,6};
            /*
            //FirstLast6(numbers);
            Console.WriteLine(FirstLast6(numbers));
            Console.ReadLine();
            numbers = new int[] {13,6,1,2,3};
            Console.WriteLine(FirstLast6(numbers));
            Console.ReadLine();

            //SameFirstLast(numbers)
            numbers = new int[] { 1, 2, 3 };
            Console.WriteLine("Array is {0} : {1}", numbers, SameFirstLast(numbers));
            Console.ReadLine();
            
            PrintArrayElements(MakePi(-2));
            Console.ReadLine();
            
            numbers = new int[] {1,2,3};
            int[] numbers2= {7,3,2};
            Console.WriteLine( commonEnd(numbers, numbers2));
            Console.ReadLine();

            numbers = new int[] { 1, 2, 15, 24, 25 };
            Console.WriteLine(Sum(numbers));
            Console.ReadLine();
            
            PrintArrayElements(RotateLeft(numbers));
            Console.ReadLine();
            
            PrintArrayElements(Reverse(numbers));
            Console.ReadLine();
            */
            numbers = new int[] { 1, 2, 15, 24, 25 };
            /*
            PrintArrayElements(HigherWins(numbers));
            Console.ReadLine();
            */
            int[] numbers2 = { 1, 5, 19, 23, 27 }; 
            /*
            PrintArrayElements(GetMiddle(numbers,numbers2));
            Console.ReadLine();
            
            Console.WriteLine(HasEven(numbers));
            Console.WriteLine(HasEven(numbers2));
            Console.ReadLine();
             
            PrintArrayElements(KeepLast(numbers));
            Console.ReadLine();
            PrintArrayElements(KeepLast(numbers2));
            Console.ReadLine();
             */
            int[] numbers3 = { 2, 3, 4, 5 };
            int[] numbers4 = { 4, 2, 3, 2 };
            int[] numbers5 = { 7, 3, 0, 2, 3 };
            /*
            Console.WriteLine(Doube23(numbers3));
            Console.WriteLine(Doube23(numbers4));
            Console.WriteLine(Doube23(numbers5));
            Console.ReadLine();
             */
            numbers3 = new int[] { 2, 3, 1, 3, 2, 2, 4, 2, 3 };
            //Console.WriteLine(Fix23(numbers3));
            /*numbers3 = Fix23(numbers3);
            Console.WriteLine(numbers3);
            Console.ReadLine();

            numbers3 = new int[] { 1, 3, 4, 5 };
            numbers4 = new int[] { 2, 1, 3, 4, 5 };
            numbers5 = new int[] { 1, 1, 2, 3, 4, 5, 1, 3 };
            Console.WriteLine(Unlucky1(numbers3));
            Console.WriteLine(Unlucky1(numbers4));
            Console.WriteLine(Unlucky1(numbers5));
            Console.ReadLine();
            
            numbers3 = new int[] { 4, 5 };
            numbers4 = new int[] { 5 };
            numbers5 = new int[] { 1, 2, 3 };
            int[] numbers6 = {};
            PrintArrayElements(Make2(numbers3,numbers5));
            Console.ReadLine();
            PrintArrayElements(Make2(numbers4,numbers5));
            Console.ReadLine();
            PrintArrayElements(Make2(numbers6, numbers5));
            Console.ReadLine();
            */
        }

        static void PrintArrayElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, numbers[i]);
        }

        static bool FirstLast6( int[] numbers)
        {
            return (numbers[0] == 6 || numbers[numbers.Length - 1] == 6);
        }

        static bool SameFirstLast( int[] numbers)
        {
            return (numbers.Length >= 1 && numbers[0] == numbers[numbers.Length - 1]);
        }

        static int[] MakePi(int n)
        {
            int[] Pi = { 3,1,4,1,5,9,2,6,5,3,5,9 };
            int k;

            if (n <= 0)
                k = 1;
            else if (n > 12)
                k = 12;
            else
                k = n;

            int[] numbers = new int[k];

            for (int i = 0; i < k; i++)
            {
                numbers[i] = Pi[i];
            }
            return numbers;
        }

        static bool commonEnd(int[] a, int[] b)
        {
            return (a.Length > 1 && b.Length > 1 && a[a.Length - 1] == b[b.Length - 1]);
        }

        static int Sum(int[] numbers)
        {
            int answer = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }

            return answer;
        }

        static int[] RotateLeft(int[] numbers)
        {
            //int[] answers = { };
            int[] answers = new int[numbers.Length];
            int first = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
              answers[i] = numbers[i + 1];
            }

            answers[answers.Length-1] = first;
            return answers;
        }

        static int[] Reverse(int[] numbers)
        {
            int[] answers = new int[numbers.Length];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                answers[i] = numbers[numbers.Length - 1 - i];
            }
            return answers;
        }

        static int[] HigherWins(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = max;
            }
            return numbers;
        }

        static int[] GetMiddle(int[] a, int[] b)
        {
            int middle_a = a.Length / 2;
            int middle_b = a.Length / 2;

            int[] answers = { a[middle_a], b[middle_b] };

            return answers;
        }

        static bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    return true;
            }

            return false;
        }

        static int[] KeepLast(int[] numbers)
        {
            int[] answers = new int[numbers.Length];

            for (int i = 0; i < answers.Length; i++)
			{
			    answers[i] = 0; 
			}

            answers[answers.Length-1] = numbers[numbers.Length-1];
            return answers;
        }

        static bool Doube23(int[] numbers)
        {
            int count_two = 0, count_three = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                    count_two++;
                else if (numbers[i] == 3)
                    count_three++;
            }

            if(count_two == 2 || count_three == 2)
                return true;

            return false;
        }

        static int[] Fix23(int[] numbers)
        {
            bool is_two = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (is_two){
                    if (numbers[i] == 3)
                    {
                        numbers[i] = 0;
                    }
                    
                    is_two = false;
                    
                }
                else if (numbers[i] == 2)
                    is_two = true;
                
            }
            return numbers;
        }

        static bool Unlucky1(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                if( i == 0  || i == 1 || i == numbers.Length-2){
                    if (numbers[i] == 1 && numbers[i + 1] == 3)
                        return true;
                }
            }
            return false;
        }

        static int[] Make2(int[] a, int[] b)
        {
            int array_size = 2;
            int[] answers = new int[array_size];

            int x;
            if(a.Length < array_size)
                x = a.Length;
            else 
                x = array_size;

            for (int i = 0; i < x; i++)
            {
                answers[i] = a[i];
            }
            for (int i = 0; i < array_size - a.Length; i++)
            {
                answers[a.Length + i] = b[i];
            }
            return answers;          
        }
    }


}
