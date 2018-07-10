﻿using System;

namespace June29Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("codingisfun", 1));
            Console.WriteLine(remove_char("codingisfun", 9));
            Console.WriteLine(remove_char("codingisfun", 0));
            Console.WriteLine(RevString("codingisfun"));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
        public static string RevString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
