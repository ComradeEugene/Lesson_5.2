using System;
using static System.Console;

namespace Lesson_5
{
    class MainClass
    {
        static string[] StrSplit(string Str)
        {
            string[] arr = Str.Split(' ');
            return arr;
        }

        static string ReversWords(string Str)
        {
            string ReversStr = "";
            string[] arr = StrSplit(Str);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                ReversStr += arr[i] + " ";
            }
            return ReversStr; 
        }

        public static void Main(string[] args)
        {
            WriteLine("Введите предложение");
            string Str = ReadLine();
            Str = ReversWords(Str);
            WriteLine(Str);
            ReadKey();
        }
    }
}
