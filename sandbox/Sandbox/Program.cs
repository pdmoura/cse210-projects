using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 10; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

    }
}