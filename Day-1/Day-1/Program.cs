using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        int i2 = Convert.ToInt32(Console.ReadLine()!);
        double d2 = Convert.ToDouble(Console.ReadLine()!);
        string s2 = Console.ReadLine()!;
        Console.WriteLine(i + i2);
        Console.WriteLine("{0:F1}", d + d2);
        Console.WriteLine("{0}{1}", s, s2);
    }
}