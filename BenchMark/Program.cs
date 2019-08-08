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
            for(int i=1;i<=10;i++) { }
           
        }
        [Benchmark]
        public void WHILE()
        {
            int x = 10;
            while(x--!=0) { }
        }
        [Benchmark]
        public void IF()
        {
            if(false) { }
        }
        [Benchmark]
        public void SWITCH()
        {
            switch(1)
            {
                case 1: break;
                default: break;
            }
        }

        [Benchmark]
        public void LIST()
        {
            List<int> list = new List<int>()
            {1,2,3,4,5,6,7,8,9,10 } ;
            foreach(int x in list) { };
            
        }

        [Benchmark]
        public void DICTIONARY()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>()
            {{1,0 } ,{ 2,0 } , {3,0}, {4,0 } , {5,0 } ,{6,0 } ,{7,0 } ,{8,0 } ,{9,0 } ,{10,0 } };
            foreach (var x in dict) { };

        }
        
        [Benchmark]
        public void STRING()
        {
            String str1 = "abcdefghij", str2="klmnopqr";
            str1 = str1 + str2; 

        }
        [Benchmark]
        public void STRINGBUILDER()
        {
            
            StringBuilder str1 = new StringBuilder("abcdefghij");
            StringBuilder str2 = new StringBuilder("klmnopqr");

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
