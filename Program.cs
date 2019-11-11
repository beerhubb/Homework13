using System;
using System.Collections.Generic;

namespace no_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new IHomework();
            var num = new List<int> { 992889, 455998, 212299, 998875, 000993};
            var result = new List<string>();
            var sut = test.Homework13(num);
            foreach (var item in sut)
            {
                var ss = item.ToString();
                if (ss.Length == 5)
                {
                    ss = "0" + ss;
                }
                else if (ss.Length == 4)
                {
                    ss = "00" + ss;
                }
                else if (ss.Length == 3)
                {
                    ss = "000" + ss;
                }
                else if (ss.Length == 2)
                {
                    ss = "0000" + ss;
                }
                else if (ss.Length == 1)
                {
                    ss = "00000" + ss;
                }
                result.Add(ss);
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}