using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMark
{
    public class MyBenchMark
    {
        [Benchmark]
        public void FOR()
        {
            for(int i=1;i<=100;i++) { }
           
        }
        [Benchmark]
        public void WHILE()
        {
            int x = 100;
            while(x--!=0) { }
        }
        [Benchmark]
        public void IF()
        { int x = 100;
            if (x == 1) { }
            else if (2 == x) { }
            else if (3 == x) { }
            else if (4 == x) { }
            else if (5 == x) { }
            else if (6 == x) { }
            else if (7 == x) { }
            else if (8 == x) { }
            else if (9 == x) { }
            else if (10 == x) { }
            else if (11 == x) { }
            else if (12 == x) { }
            else if (13 == x) { }
            else if (14 == x) { }
            else if (15 == x) { }
            else if (16 == x) { }
            else if (17 == x) { }
            else if (18 == x) { }
            else if (19 == x) { }
            else if (20 == x) { }
            else if (21 == x) { }
            else if (22 == x) { }
            else if (23 == x) { }
            else if (24 == x) { }
            else if (25 == x) { }
            else if (26 == x) { }
            else if (27 == x) { }
            else if (28 == x) { }
            else if (29 == x) { }
            else if (30 == x) { }
            else if (31 == x) { }
            else if (32 == x) { }
            else if (33 == x) { }
            else if (34 == x) { }
            else if (35 == x) { }
            else if (36 == x) { }
            else if (37 == x) { }
            else if (38 == x) { }
            else if (39 == x) { }
            else if (40 == x) { }
            else if (41 == x) { }
            else if (42 == x) { }
            else if (43 == x) { }
            else if (44 == x) { }
            else if (45 == x) { }
            else if (46 == x) { }
            else if (47 == x) { }
            else if (48 == x) { }
            else if (49 == x) { }
            else if (50 == x) { }
            else if (51 == x) { }
            else if (52 == x) { }
            else if (53 == x) { }
            else if (54 == x) { }
            else if (55 == x) { }
            else if (56 == x) { }
            else if (57 == x) { }
            else if (58 == x) { }
            else if (59 == x) { }
            else if (60 == x) { }
            else if (61 == x) { }
            else if (62 == x) { }
            else if (63 == x) { }
            else if (64 == x) { }
            else if (65 == x) { }
            else if (66 == x) { }
            else if (67 == x) { }
            else if (68 == x) { }
            else if (69 == x) { }
            else if (70 == x) { }
            else if (71 == x) { }
            else if (72 == x) { }
            else if (73 == x) { }
            else if (74 == x) { }
            else if (75 == x) { }
            else if (76 == x) { }
            else if (77 == x) { }
            else if (78 == x) { }
            else if (79 == x) { }
            else if (80 == x) { }
            else if (81 == x) { }
            else if (82 == x) { }
            else if (83 == x) { }
            else if (84 == x) { }
            else if (85 == x) { }
            else if (86 == x) { }
            else if (87 == x) { }
            else if (88 == x) { }
            else if (89 == x) { }
            else if (90 == x) { }
            else if (91 == x) { }
            else if (92 == x) { }
            else if (93 == x) { }
            else if (94 == x) { }
            else if (95 == x) { }
            else if (96 == x) { }
            else if (97 == x) { }
            else if (98 == x) { }
            else if (99 == x) { }
            else if (100 == x) { }
            else { }


        }
        [Benchmark]
        public void SWITCH()
        { int x = 100;
            switch(x)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 7: break;
                case 8: break;
                case 9: break;
                case 10: break;
                case 11: break;
                case 12: break;
                case 13: break;
                case 14: break;
                case 15: break;
                case 16: break;
                case 17: break;
                case 18: break;
                case 19: break;
                case 20: break;
                case 21: break;
                case 22: break;
                case 23: break;
                case 24: break;
                case 25: break;
                case 26: break;
                case 27: break;
                case 28: break;
                case 29: break;
                case 30: break;
                case 31: break;
                case 32: break;
                case 33: break;
                case 34: break;
                case 35: break;
                case 36: break;
                case 37: break;
                case 38: break;
                case 39: break;
                case 40: break;
                case 41: break;
                case 42: break;
                case 43: break;
                case 44: break;
                case 45: break;
                case 46: break;
                case 47: break;
                case 48: break;
                case 49: break;
                case 50: break;
                case 51: break;
                case 52: break;
                case 53: break;
                case 54: break;
                case 55: break;
                case 56: break;
                case 57: break;
                case 58: break;
                case 59: break;
                case 60: break;
                case 61: break;
                case 62: break;
                case 63: break;
                case 64: break;
                case 65: break;
                case 66: break;
                case 67: break;
                case 68: break;
                case 69: break;
                case 70: break;
                case 71: break;
                case 72: break;
                case 73: break;
                case 74: break;
                case 75: break;
                case 76: break;
                case 77: break;
                case 78: break;
                case 79: break;
                case 80: break;
                case 81: break;
                case 82: break;
                case 83: break;
                case 84: break;
                case 85: break;
                case 86: break;
                case 87: break;
                case 88: break;
                case 89: break;
                case 90: break;
                case 91: break;
                case 92: break;
                case 93: break;
                case 94: break;
                case 95: break;
                case 96: break;
                case 97: break;
                case 98: break;
                case 99: break;
                case 100: break;
                default: break;
            }
        }

        [Benchmark]
        public void LIST()
        {
            List<int> list = new List<int>()
            {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,
            31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,
            61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,
            91,92,93,94,95,96,97,98,99,100
            } ;
            foreach(int x in list) { };
            
        }

        [Benchmark]
        public void DICTIONARY()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>()
            { { 1,0 } ,{ 2,0 } , {3,0}, {4,0 } , {5,0 } ,{6,0 } ,{7,0 } ,{8,0 } ,{9,0 } ,{10,0 } ,
             { 11 ,0 } ,{12,0 } , { 13,0}, { 14,0 } , {15,0 } ,{ 16,0 } ,{ 17,0 } ,{ 18,0 } ,{ 19,0 } ,{ 20,0 } ,
             { 21,0 } ,{ 22,0 } , { 23,0}, {24,0 } , { 25,0 } ,{ 26,0 } ,{ 27,0 } ,{ 28,0 } ,{ 29,0 } ,{ 30,0 } ,
             { 31,0 } ,{ 32,0 } , { 33,0}, { 34,0 } , { 35,0 } ,{ 36,0 } ,{ 37,0 } ,{ 38,0 } ,{ 39,0 } ,{ 40,0 } ,
             { 41,0 } ,{ 42,0 } , { 43,0}, { 44,0 } , { 45,0 } ,{ 46,0 } ,{ 47,0 } ,{ 48,0 } ,{ 49,0 } ,{ 50,0 } ,
             { 61,0 } ,{ 62,0 } , { 63,0}, { 64,0 } , { 65,0 } ,{ 66,0 } ,{ 67,0 } ,{ 68,0 } ,{ 69,0 } ,{ 60,0 } ,
             { 51,0 } ,{ 52,0 } , { 53,0}, { 54,0 } , { 55,0 } ,{ 56,0 } ,{ 57,0 } ,{ 58,0 } ,{ 59,0 } ,{ 70,0 } ,
             { 71,0 } ,{ 72,0 } , { 73,0}, { 74,0 } , { 75,0 } ,{ 76,0 } ,{ 77,0 } ,{ 78,0 } ,{ 79,0 } ,{ 80,0 } ,
             { 81,0 } ,{ 82,0 } , { 83,0}, { 84,0 } , { 85,0 } ,{ 86,0 } ,{ 87,0 } ,{ 88,0 } ,{ 89,0 } ,{ 90,0 } ,
             { 91,0 } ,{ 92,0 } , { 93,0}, { 94,0 } , { 95,0 } ,{ 96,0 } ,{ 97,0 } ,{ 98,0 } ,{ 99,0 } ,{ 100,0 } };
           
            foreach (var x in dict) { };

        }
        
        [Benchmark]
        public void STRING()
        {
            String str1 = "abcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqr";
            String str2 = "abcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqr";
            str1 = str1 + str2; 

        }
        [Benchmark]
        public void STRINGBUILDER()
        {
            
            StringBuilder str1 = new StringBuilder("abcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqr");
            StringBuilder str2 = new StringBuilder("abcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqrabcdefghijklmnopqr");

            str1.Append(str2);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var reports = BenchmarkRunner.Run<MyBenchMark>();
            Console.WriteLine(reports.Reports);
            Console.ReadKey();
        }
    }
}
