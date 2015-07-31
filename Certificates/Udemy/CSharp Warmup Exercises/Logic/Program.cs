using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSharpExercise.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(GreatParty(30, false));
            Console.WriteLine(GreatParty(50, false));
            Console.WriteLine(GreatParty(70, true));
            Console.ReadLine();
            
            Console.WriteLine(CanHazTable(5, 10));
            Console.WriteLine(CanHazTable(2, 5));
            Console.WriteLine(CanHazTable(5, 5));
            Console.ReadLine();
            
            Console.WriteLine(PlayOutside(70, false));
            Console.WriteLine(PlayOutside(95, false));
            Console.WriteLine(PlayOutside(95, true));
            Console.ReadLine();
            
            Console.WriteLine(CaughtSpeeding(60, false));
            Console.WriteLine(CaughtSpeeding(65, false));
            Console.WriteLine(CaughtSpeeding(65, true));
            Console.ReadLine();
            
            Console.WriteLine(SkipSum(3, 4));
            Console.WriteLine(SkipSum(9, 4));
            Console.WriteLine(SkipSum(10, 11));
            Console.ReadLine();
            
            Console.WriteLine(AlarmClock(1, false));
            Console.WriteLine(AlarmClock(5, false));
            Console.WriteLine(AlarmClock(0, true));
            Console.ReadLine();
            
            Console.WriteLine(LoveSix(6,4));
            Console.WriteLine(LoveSix(4,5));
            Console.WriteLine(LoveSix(1,5));
            Console.ReadLine();
            
            Console.WriteLine(InRange(5, false));
            Console.WriteLine(InRange(11, false));
            Console.WriteLine(InRange(11, true));
            Console.ReadLine();
            
            Console.WriteLine(SpecialEleven(22));
            Console.WriteLine(SpecialEleven(23));
            Console.WriteLine(SpecialEleven(24));
            Console.ReadLine();
            
            Console.WriteLine(Mod20(40));
            Console.WriteLine(Mod20(41));
            Console.WriteLine(Mod20(42));
            Console.ReadLine();
            
            Console.WriteLine(Mod35(3));
            Console.WriteLine(Mod35(10));
            Console.WriteLine(Mod35(15));
            Console.ReadLine();
            
            Console.WriteLine(AnswerCell(false,false,false));
            Console.WriteLine(AnswerCell(false,false,true));
            Console.WriteLine(AnswerCell(true,false,false));
            Console.ReadLine();
            
            Console.WriteLine(TwoIsOne(1,2,3));
            Console.WriteLine(TwoIsOne(3,1,2));
            Console.WriteLine(TwoIsOne(3,2,2));
            Console.ReadLine();
            
            Console.WriteLine(AreInOrder(1, 2, 4, false));
            Console.WriteLine(AreInOrder(1, 2, 1, false));
            Console.WriteLine(AreInOrder(1, 1, 2, true));
            Console.ReadLine();
            
            Console.WriteLine(InOrderEqual(2, 5, 11, false));
            Console.WriteLine(InOrderEqual(2, 7, 6, false));
            Console.WriteLine(InOrderEqual(5, 5, 7, true));
            Console.ReadLine();
            
            Console.WriteLine(LastDigit(23,19,13));
            Console.WriteLine(LastDigit(23,19,12));
            Console.WriteLine(LastDigit(23,19,3));
            Console.ReadLine();
            
            Console.WriteLine(RollDice(6,6,true));
            Console.WriteLine(RollDice(3,3, true));
            Console.WriteLine(RollDice(3, 3, false));
            Console.ReadLine();
            */
        }

        static bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
                return (cigars > 40);

            return (cigars > 40 && cigars < 60);
        }

        static int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle <= 2 || dateStyle <= 2)
                return 0;
            if (yourStyle >= 8 || dateStyle >= 8)
                return 2;
            return 1;
        }

        static bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer)
                return (temp >= 60 && temp <= 100);
            return (temp >= 60 && temp <= 90);
        }

        static int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday)
                if (speed <= 65)
                    return 0;
                else if (speed <= 85)
                    return 1;
                else return 2;
            else
                if (speed <= 60)
                    return 0;
                else if (speed <= 80)
                    return 1;

            return 2;
        }

        static int SkipSum(int a, int b)
        {
            if (a + b >= 10 && a + b <= 19)
                return 20;
            return a + b;
        }

        static string AlarmClock(int day, bool vacation)
        {
            if (!vacation)
                if (day == 0 || day == 6)
                    return "10:00";
                else
                    return "7:00";
            else
                if (day == 0 || day == 6)
                    return "off";
                else
                    return "10:00";
        }

        static bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6 || a + b == 6 || a - b == 6 || b - a == 6)
                return true;
            return false;
        }

        static bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
                return (n <= 1 || n >= 10);
            return (n > 1 && n < 10);
        }

        static bool SpecialEleven(int n)
        {
            return (n % 11 == 0 || n % 11 == 1);
        }

        static bool Mod20(int n)
        {
            return (n % 20 == 1 || n % 20 == 2);
        }

        static bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                return false;
            if (n % 3 == 0 || n % 5 == 0)
                return true;

            return false;
        }

        static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
                return false;
            if (isMorning && !isMom)
                return false;

            return true;
        }

        static bool TwoIsOne(int a, int b, int c)
        {
            return (a + b == c || a + c == b || c + b == a);
        }

        static bool AreInOrder(int a, int b, int c, bool bOk)
        {
            return ((a < b || bOk) && b < c);
        }

        static bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
                return (a <= b && b <= c);

            return (a < b && b < c);
        }

        static bool LastDigit(int a, int b, int c)
        {
            return (a % 10 == b % 10 || b % 10 == c % 10 || a % 10 == c % 10);
        }

        static int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
                if (die1 == die2)
                    if (die2 == 6)
                        return 7;
                    else
                        return die1 + die2 + 1;
            
            return die1 + die2;
        }
    }
}
