using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2020
{
    public class Program
    {
        static void Main(string[] args)
        {
            string NumberList = File.ReadAllText(@"C:\Users\Vinni\source\repos\AdventOfCode2020\Day1.txt");
            Console.WriteLine($"The Answer is: {ReportRepair1(NumberList)}");
            Console.WriteLine($"The Answer is: {ReportRepair2(NumberList)}");
        }

        public static double ReportRepair1(string NumsList)
        {
            var numbers = NumsList.Split('\n');
            double Ans = 0;
            var intnum = new List<int>();

            foreach (var x in numbers)
            {
                intnum.Add(Convert.ToInt32(x));
            }
            for (int i = 0; i < intnum.Count; i++)
            {
                for (int j = 1; j < intnum.Count; j++)
                {
                    if (intnum[i] + intnum[j] == 2020)
                    {
                        Ans = intnum[i] * intnum[j];
                    }
                }
            }
            return Ans;
        }
        public static double ReportRepair2(string NumsList)
        {
            var numbers = NumsList.Split('\n');
            double Ans = 0;
            var intnum = new List<int>();
            int[] numArray = new int[3];

            foreach (var x in numbers)
            {
                intnum.Add(Convert.ToInt32(x));
            }
            for (int i = 0; i < intnum.Count; i++)
            {
                for (int j = 1; j < intnum.Count; j++)
                {
                    for (int k = 2; k < intnum.Count; k++)
                    {
                        if (intnum[i] + intnum[j] + intnum[k] == 2020)
                        {
                            numArray[0] = intnum[i];
                            numArray[1] = intnum[j];
                            numArray[2] = intnum[k];
                            Ans = intnum[i] * intnum[j] * intnum[k];
                        }
                    }
                }
            }
            return Ans;
        }
    }
}
