using NUnit.Framework;
using AdventOfCode2020;
using System.Collections.Generic;

namespace AdventOfCode2020Tests
{
    public class Tests
    {

        [TestCase(("1721 \n 979 \n 366 \n 299\n 675 \n1456"), 514579)]
        public void Part1_GivenStringofNumber_Find2WithSumof2020_return_ProductOFthe2Nums(string input, double answer)
        {
            Assert.That(Program.ReportRepair1(input), Is.EqualTo(answer));
        }

        [TestCase(("1721 \n 979 \n 366 \n 299\n 675 \n1456"), 241861950)]
        public void Part2_GivenStringofNumber_Find3WithSumof2020_return_ProductOFthe3Nums(string input, double answer)
        {
            Assert.That(Program.ReportRepair2(input), Is.EqualTo(answer));
        }
    }
}