﻿using System;

namespace Sample205
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;

            Console.Write("str1=");       //writeにしていることで次のReadLineと同行で表示している
            str1 = Console.ReadLine();

            Console.Write("str2=");
            str2 = Console.ReadLine();

            Console.WriteLine("入力結果は、str1 + str2 = {0} です", str1 + str2);
        }
    }
}
