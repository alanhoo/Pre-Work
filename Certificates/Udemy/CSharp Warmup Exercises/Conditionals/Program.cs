using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSharpExercise.Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(AreWeInTrouble(true, false));
            Console.WriteLine(AreWeInTrouble(true, true));
            Console.WriteLine(AreWeInTrouble(false, false));
            Console.ReadLine();

            Console.WriteLine(CanSleepIn(true, false));
            Console.WriteLine(CanSleepIn(true, true));
            Console.WriteLine(CanSleepIn(false, true));
            Console.ReadLine();
            
            Console.WriteLine(SumDouble(1,2 ));
            Console.WriteLine(SumDouble(3,2 ));
            Console.WriteLine(SumDouble(2,2 ));
            Console.ReadLine();
            
            Console.WriteLine(Diff21(23));
            Console.WriteLine(Diff21(10));
            Console.WriteLine(Diff21(21));
            Console.ReadLine();
            
            Console.WriteLine(ParrotTrouble(true,6));
            Console.WriteLine(ParrotTrouble(true,7));
            Console.WriteLine(ParrotTrouble(false,6));
            Console.ReadLine();
            
            Console.WriteLine(Makes10(9, 10));
            Console.WriteLine(Makes10(9, 7));
            Console.WriteLine(Makes10(4, 6));
            Console.ReadLine();
            
            Console.WriteLine(NearHundred(103));
            Console.WriteLine(NearHundred(90));
            Console.WriteLine(NearHundred(89));
            Console.ReadLine();
            
            Console.WriteLine(PosNeg(1,-1,false));
            Console.WriteLine(PosNeg(3,1,false));
            Console.WriteLine(PosNeg(-2,-3,true));
            Console.ReadLine();
            
            Console.WriteLine(NotString("Candy"));
            Console.WriteLine(NotString("Hat"));
            Console.WriteLine(NotString("Not bad"));
            Console.ReadLine();
            
            Console.WriteLine(MissingChar("Candy",1));
            Console.WriteLine(MissingChar("Hat",0));
            Console.WriteLine(MissingChar("Not bad",4));
            Console.ReadLine();
            
            Console.WriteLine(FrontBack("code"));
            Console.WriteLine(FrontBack("a"));
            Console.WriteLine(FrontBack("ad"));
            Console.ReadLine();
            
            Console.WriteLine(Front3("Microsoft"));
            Console.WriteLine(Front3("Chocolate"));
            Console.WriteLine(Front3("at"));
            Console.ReadLine();
            
            Console.WriteLine(BackAround("cat"));
            Console.WriteLine(BackAround("hello"));
            Console.WriteLine(BackAround("at"));
            Console.ReadLine();
            
            Console.WriteLine(Multiple3or5(3));
            Console.WriteLine(Multiple3or5(10));
            Console.WriteLine(Multiple3or5(8));
            Console.ReadLine();
            
            Console.WriteLine(StartHi("hi there"));
            Console.WriteLine(StartHi("hi"));
            Console.WriteLine(StartHi("igh up"));
            Console.ReadLine();
            
            Console.WriteLine(IcyHot(120,-1));
            Console.WriteLine(IcyHot(-1,120));
            Console.WriteLine(IcyHot(2,120));
            Console.ReadLine();
            
            Console.WriteLine(HasTeen(13,20,10));
            Console.WriteLine(HasTeen(20,19,10));
            Console.WriteLine(HasTeen(20,10,12));
            Console.ReadLine();
            
            Console.WriteLine(SoAlone(99, 13));
            Console.WriteLine(SoAlone(21, 19));
            Console.WriteLine(SoAlone(13, 13));
            Console.ReadLine();
            
            Console.WriteLine(RemoveDel("adelbc"));
            Console.WriteLine(RemoveDel("adelHello"));
            Console.WriteLine(RemoveDel("adedbc"));
            Console.ReadLine();
            
            Console.WriteLine(IxStart("pix snacks"));
            Console.WriteLine(IxStart("adelHello"));
            Console.WriteLine(IxStart("piz snacks"));
            Console.ReadLine();
            
            Console.WriteLine(StartOz("ozymandias"));
            Console.WriteLine(StartOz("bzoo"));
            Console.WriteLine(StartOz("oxx"));
            Console.ReadLine();
            
            Console.WriteLine(Max(1,2,3));
            Console.WriteLine(Max(5,8,9));
            Console.WriteLine(Max(13344,2334444,109999));
            Console.ReadLine();
            
            Console.WriteLine(Closer(8, 13));
            Console.WriteLine(Closer(13, 8));
            Console.WriteLine(Closer(13,7));
            Console.ReadLine();
            
            Console.WriteLine(GotE("Hello"));
            Console.WriteLine(GotE("Heelle"));
            Console.WriteLine(GotE("Heelele"));
            Console.ReadLine();
            
            Console.WriteLine(EndUp("Hello"));
            Console.WriteLine(EndUp("hi there"));
            Console.WriteLine(EndUp("hiii"));
            Console.ReadLine();
            */
            Console.WriteLine(EveryNth("Miracle",2));
            Console.WriteLine(EveryNth("abcdefg",2));
            Console.WriteLine(EveryNth("abcdefg",3));
            Console.ReadLine();
        }

        static bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return (aSmile == bSmile);
        }

        static bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            return (!isWeekday || isVacation);
        }

        static int SumDouble(int a , int b)
        {
            if (a == b)
                return (a + b) * 2;
            return a + b;
        }

        static int Diff21(int n)
        {
            if (n > 21)
                return (n - 21) * 2;
            return Math.Abs(n - 21);
        }

        static bool ParrotTrouble(bool isTalking, int hour)
        {
            return (isTalking && (hour < 7 || hour > 20));
        }

        static bool Makes10(int a, int b)
        {
            return (a == 10 || b == 10 || a + b == 10);
        }

        static bool NearHundred(int n)
        {
            return (Math.Abs(n-100)<=10 || Math.Abs(n-200)<=10);
        }

        static bool PosNeg(int a, int b, bool negative)
        {                  
            if (negative)
                return (a < 0 && b < 0);
            return (a < 0 || b < 0);
        }

        static string NotString(string s)
        {
            if (s.Substring(0, 3) == "Not")
                return s;
            return "Not " + s;
        }

        static string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        static string FrontBack(string str)
        {
            if (str.Length > 2)
                return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
            else if (str.Length == 2)
                return str[1].ToString() + str[0];
            else
                return str;
        }

        static string Front3(string str)
        {
            if (str.Length <= 3)
                return str;
            string answers = str.Substring(0,3);
            return answers + answers + answers;
        }

        static string BackAround(string str)
        {
            return str[str.Length - 1] + str + str[str.Length - 1];
        }

        static bool Multiple3or5(int number)
        {
            return (number % 3 == 0 || number % 5 == 0);
        }

        static bool StartHi(string str)
        {
            return (str.Substring(0, 2) == "hi");
        }

        static bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 < 0 && temp2 > 100) || (temp2 < 0 && temp1 > 100))
                    return true;
            return false;
        }

        static bool Between10and20(int a, int b)
        {
            return ((a >= 10 && a <= 20) || (b >= 10 && b <= 20));
        }

        static bool HasTeen(int a, int b, int c)
        {
            return ((a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19));
        }

        static bool SoAlone(int a, int b)
        {
            if (a >= 13 && a <= 19)
                if (b < 13 || b > 19)
                    return true;
                else
                    return false;
            else
                if (b >= 13 && b <= 19)
                    return true;
                else
                    return false;
        }

        static string RemoveDel(string str)
        {
            if (str.Substring(1, 3) == "del")
                return str.Remove(1, 3);
            return str;
        }

        static bool IxStart(string str)
        {
            return (str.Substring(1, 2) == "ix");
        }

        static string StartOz(string str)
        {
            if (str.Substring(0, 2) == "oz")
                return str.Substring(0,2);
            if (str[0] == 'o')
                return str.Substring(0, 1);
            if (str[1] == 'z')
                return str.Substring(1, 1);
            return str;
        }

        static int Max(int a, int b, int c)
        {
            return (Math.Max(Math.Max(a, b), Math.Max(b, c)));
        }

        static int Closer(int a, int b)
        {
            if (Math.Abs(a - 10) < Math.Abs(b - 10))
                return a;
            else if (Math.Abs(a - 10) == Math.Abs(b - 10))
                return 0;
            return b;
        }

        static bool GotE(string str)
        {
            int CountE = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                    CountE++;
                if (CountE > 3)
                    return false;
            }
            if (CountE >= 1 && CountE <= 3)
                return true;
            return false;
        }

        static string EndUp(string str)
        {
            if (str.Length < 3)
                return str.ToUpper();
            return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
        }

        static string EveryNth(string str, int n)
        {
            string answer = "";
            for (int i = 0; i < str.Length; i += n)
            {
                answer += str[i];
            }
            return answer;
        }
    }
}
