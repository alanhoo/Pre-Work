using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSharpExercise.@string
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "MartyFriedman";
            Console.WriteLine(SayHi(name));
            Console.ReadLine();
            
            string name2 = "SteveVai";
             /* 
            Console.WriteLine(Abba(name, name2));
            Console.ReadLine();

            Console.WriteLine("She said, \"Hello\"");
            Console.WriteLine("c:\\Windows is normally where the Windows folder is.");
            Console.WriteLine("Let's print 3 blank lines after this.\n\n\n");
            string tag = "j";
            Console.WriteLine(MakeTags(tag,name));
            Console.ReadLine();
            

            string container = "<<><>>";
            Console.WriteLine(InsertWord(container, name));
            Console.ReadLine();

            Console.WriteLine(MultipleEndings(name));
            Console.ReadLine();

            Console.WriteLine(FirstHalf(name));
            Console.ReadLine();
            
            Console.WriteLine(TrimOne(name));
            Console.ReadLine();

            Console.WriteLine(LongInMiddle(name,name2));
            Console.ReadLine();
            
            Console.WriteLine(RotateLeft2(name2));
            string name3 = "ab";
            Console.WriteLine(RotateLeft2(name));
            Console.ReadLine();

            Console.WriteLine(RotateRight2(name2));
            //string name3 = "ab";
            Console.WriteLine(RotateRight2(name));
            Console.ReadLine();
            
            Console.WriteLine(TakeOne(name2,true));
            //string name3 = "ab";
            Console.WriteLine(TakeOne(name,false));
            Console.ReadLine();

            Console.WriteLine(MiddleTwo(name2));
            //string name3 = "ab";
            Console.WriteLine(MiddleTwo(name));
            Console.ReadLine();
            
            Console.WriteLine(EndsWithLy(name2));
            string name3 = "abbbly";
            Console.WriteLine(EndsWithLy(name3));
            Console.ReadLine();

            Console.WriteLine(FrontAndBack(name2,3));
            //string name3 = "abbbly";
            Console.WriteLine(FrontAndBack(name,4));
            Console.ReadLine();
            
            Console.WriteLine(TakeTwoFromPosition(name2, 3));
            Console.WriteLine(TakeTwoFromPosition(name, 4));
            Console.ReadLine();

            string name3 = "badxxxx";
            string name4 = "xxbadxxx";
            string name5 = "xbadxxx";
            Console.WriteLine(HasBad(name3));
            Console.WriteLine(HasBad(name4));
            Console.WriteLine(HasBad(name));
            Console.WriteLine(HasBad(name5));
            Console.ReadLine();
            
            Console.WriteLine(AtFirst(name));
            string name3 = "a";
            Console.WriteLine(AtFirst(name3));
            Console.ReadLine();
            
            Console.WriteLine(LastChars(name2,name));
            string name3 = "";
            Console.WriteLine(LastChars(name3,name2));
            Console.ReadLine();
            
            Console.WriteLine(ConCat(name2, name));
            string name3 = "nabc";
            Console.WriteLine(ConCat(name, name3));
            Console.ReadLine();
            
            Console.WriteLine(SwapLast(name));
            string name3 = "c";
            Console.WriteLine(SwapLast(name3));
            Console.ReadLine();
            
            Console.WriteLine(FrontAgain(name));
            string name3 = "aberrab";
            string name4 = "ab";
            Console.WriteLine(FrontAgain(name4));
            Console.WriteLine(FrontAgain(name3));
            Console.ReadLine();
            
            Console.WriteLine(MinCat(name, name2));
            string name3 = "aberrab";
            string name4 = "aber";
            Console.WriteLine(MinCat(name4,name3));
            Console.WriteLine(MinCat(name3,name4));
            Console.ReadLine();
            
            Console.WriteLine(TweakFront(name));
            string name3 = "aberrab";
            string name4 = "away";
            Console.WriteLine(TweakFront(name3));
            Console.WriteLine(TweakFront(name4));
            Console.ReadLine();

            Console.WriteLine(StripX(name));
            string name5 = "xaberrabx";
            string name6 = "awayx";
            Console.WriteLine(StripX(name5));
            Console.WriteLine(StripX(name6));
            Console.ReadLine();
              */ 
        }

        static string SayHi(string name)
        {
            return "Hello " + name + "!"; 
        }

        static string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        static string MakeTags(string tag, string content)
        {
            return "<"+tag+">" + content + "</" + tag + ">";
        }

        static string InsertWord(string container, string word)
        {
            return container.Substring(0, container.Length/2) + word + container.Substring(container.Length/2, container.Length/2);
        }

        static string MultipleEndings(string str)
        {
            string sub = str.Substring(str.Length - 2, 2);
            return sub + sub + sub;
        }

        static string FirstHalf(string str)
        {
            return str.Substring(0, str.Length/2);
        }

        static string TrimOne(string str)
        {
            return str.Substring(1, str.Length-2);
        }

        static string LongInMiddle(string a, string b)
        {
            if (a.Length < b.Length)
                return a + b + a;
            else
                return b + a + b;
        }

        static string RotateLeft2(string str)
        {
            if (str.Length > 2)
                return str.Substring(2, str.Length - 2) + str.Substring(0, 2);
            else
                return str;
        }

        static string RotateRight2(string str)
        {
            if (str.Length > 2)
                return str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2);
            else
                return str;
        }

        static string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
                return str[0].ToString();
            else
                return str[str.Length - 1].ToString();
        }

        static string MiddleTwo(string str)
        {
            return str.Substring(str.Length/2-1,2);
        }

        static bool EndsWithLy(string str)
        {
            return (str.Substring(str.Length - 2, 2) == "ly");
        }

        static string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
        }

        static string TakeTwoFromPosition(string str, int n)
        {
            if (n < 0 || n >= str.Length - 1)
                n = 0;
            return str.Substring(n, 2); 
        }

        static bool HasBad(string str)
        {
            for (int i = 0; i <= 1; i++)
            {
                if (str.Substring(i, 3) == "bad")
                    return true;
            }
            return false;
        }

        static string AtFirst(string str)
        {
            if (str.Length < 2)
                //return string.Concat(str, "@");
                return str + "@";
            return str.Substring(0,2);
        }

        static string LastChars(string a, string b)
        {
            if (a.Length == 0)
                a = "@";
            if (b.Length == 0)
                b = "@";

            return (a[0].ToString() + b[b.Length - 1].ToString());
        }

        static string ConCat(string a, string b)
        {
            if (a[a.Length - 1] == b[0])
                b = b.Substring(1, b.Length - 1);

            return a + b;
        }

        static string SwapLast(string str)
        {
            if (str.Length < 2)
                return str;

            return str.Substring(0, str.Length - 2) + str[str.Length - 1].ToString() + str[str.Length - 2].ToString(); 
        }

        static bool FrontAgain(string str)
        {
            return (str.Substring(0, 2) == str.Substring(str.Length - 2, 2));
        }

        static string MinCat(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a + b.Substring(0, a.Length);
            }
            else
            {
                return a.Substring(a.Length - b.Length) + b;
            }
        }

        static string TweakFront(string str)
        {
            string front = "";
            if (str[0] == 'a')
                front += "a";
            if (str[1].ToString() == "b")
                front += "b";

            return front + str.Substring(2);
        }

        static string StripX(string str)
        {
            if (str[0] == 'x')
                str = str.Substring(1);
            if (str[str.Length - 1] == 'x')
                str = str.Substring(0, str.Length - 1);

            return str;
        }
    }
}
