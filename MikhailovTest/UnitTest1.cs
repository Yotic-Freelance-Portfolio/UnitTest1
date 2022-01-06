using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MikhailovTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ex1()
        {
            int[,] nums1 = new int[5, 5]
            {
                { 10,45,-74,1,38 },
                { -38,9,28,-1,99 },
                { 2,44,-84,15,100 },
                { -1,-19,-9,11,3 },
                { 11,34,-15,15,0 },
            };
            int mod1 = 0;
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                    if (nums1[x, y] < 0)
                        mod1 += nums1[x, y];
            Console.WriteLine("Test #1: " + Math.Abs(mod1));
        }
        [TestMethod]
        public void ex2_9()
        {
            int[][] nums2 = new int[5][]
            {
                new int[5] { 10, 46, 74, 2, 38 },
                new int[5] { 38,9,28,1,99 },
                new int[5] { 2,44,84,16,100 },
                new int[5] { 1,19,9,11,3 },
                new int[5] { 12,34,16,18,2 },
            };
            Console.WriteLine("Test #2: ");
            nums2.ToList().ForEach(x => { if (x.Where(c => c % 2 == 0).Count() == 5 && x.First() > x.Last()) x.ToList().ForEach(c => Console.Write(c)); });
        }
        [TestMethod]
        public void ex3_7_8()
        {
            Console.WriteLine("Test #3: ");
            const int m3 = 5, n3 = 5;
            int[][] nums3 = new int[m3][]
            {
                new int[n3] { -10, -46, 74, 2, 38 },
                new int[n3] { 38,-9,-28,1,99 },
                new int[n3] { 2,44,84,-16,100 },
                new int[n3] { 1,-19,9,-11,3 },
                new int[n3] { -12,34,-16,18,2 },
            };
            for (int x = 0; x < m3; x++)
            {
                int pos3 = 0;
                for (int y = 0; y < n3; y++)
                {
                    if (pos3 == 2)
                    {
                        List<int> tempnumbers3 = new List<int>();
                        for(int i = y; i < n3; i++)
                        {
                            tempnumbers3.Add(nums3[x][i]);
                        }
                        tempnumbers3.OrderBy(x => x).ToList().ForEach(x => Console.Write(x));
                        Console.Write("; ");
                        break;
                    }
                    else if (nums3[x][y] < 0) pos3++;
                }
            }
        }
        [TestMethod]
        public void ex4()
        {
            int[][] nums4 = new int[5][]
            {
                new int[5] { -10, -46, 74, 2, 38 },
                new int[5] { 38,-9,-28,1,99 },
                new int[5] { 2,44,84,-16,100 },
                new int[5] { 1,-19,9,-11,3 },
                new int[5] { -12,34,-16,18,2 },
            };
            int pronum4 = 1;
            nums4.ToList().ForEach(x => { if (x.ToList().Count(c => c < 0) == 0) x.ToList().ForEach(c => pronum4 *= c); });
            Console.WriteLine("Test #4: " + pronum4);
        }
        [TestMethod]
        public void ex5_10_11_14()
        {
            int[][] nums5 = new int[8][]
            {
                new int[8] { -10, -46, 74, 2, 38 , 74, 2, 38 },
                new int[8] { 38,-9,-28,1,99 ,-28,1,99 },
                new int[8] { 2,44,84,-16,100 ,84,-16,100 },
                new int[8] { 1,-19,9,-11,3 ,9,-11,3 },
                new int[8] { -12,34,-16,18,2 ,-16,18,2},
                new int[8] { 2,44,84,-16,100 ,84,-16,100 },
                new int[8] { 1,-19,9,-11,3 ,9,-11,3 },
                new int[8] { -12,34,-16,18,2 ,-16,18,2 },
            };
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    for (int x2 = 0; x2 < 8; x2++)
                    {
                        for (int y2 = 0; y2 < 8; y2++)
                        {
                            if (nums5[x][y] == nums5[y2][x2]) continue;
                            else break;
                        }
                    }
            Console.WriteLine("Test #5.2: ");
            nums5.ToList().ForEach(x => { if (x.Count(c => c < 0) > 0) Console.Write(x.Sum() + ", "); });
        }
        [TestMethod]
        public void ex6()
        {
            int[][] nums6 = new int[5][]
            {
                new int[5] { 10, 46, 74, 2, 38 },
                new int[5] { 38,9,28,1,99 },
                new int[5] { 2,44,84,16,100 },
                new int[5] { 1,19,9,11,3 },
                new int[5] { 12,34,16,18,2 },
            };
            Console.WriteLine("Test #6: ");
            for (int x = 1; x < 5; x++)
                for (int x2 = 0; x2 < 5; x2++)
                    for (int y = 0; y < 5; y++)
                        if (nums6[x - 1].ToList().Contains(nums6[x2][y]))
                            Console.Write((x - 1) + "&" + x2 + ", ");
        }

        [TestMethod]
        public void ex20()
        {
            Console.WriteLine("Test #20: ");
            IEnumerable<int> nums20 = new List<int>() { 5, 41, 78125, 90, 125};
            nums20.ToList().ForEach(x => {
                int c = x;
                while(c > 5) c /= 5;
                if (c == 5) Console.Write(x + ", ");
            });
            Console.Write(" = Степени 5");
        }

        [TestMethod]
        public void ex15_16_19()
        {
            NMin(new int[] { 12, 1, 12, 12414, 124, 41, 412 ,638 , 762}, 12);
            NMax(new int[] { 12, 1, 12, 12414, 124, 41, 412, 638, 762 }, 12);
        }

        [TestMethod]
        public void ex17_18()
        {
            NewStr("      C# — объектно-ориентированный язык программирования. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft .NET Framework.     ");
        }

        public int NMin(int[] A, int N) => A.Min();
        public int NMax(int[] A, int N) => A.Max();
        public string NewStr(string S) => S.TrimEnd().TrimStart();
    }
}