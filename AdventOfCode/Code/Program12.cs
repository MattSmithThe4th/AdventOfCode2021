using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Code {
    class Program12 {

        public int Run() {
            string[] arr = System.IO.File.ReadAllLines(@"C:\Users\Matt Smith\source\repos\AdventOfCode\AdventOfCode\txt\Day11.txt");
            int res = 0;
            List<int> ints = new();
            List<int> sum = new();

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<STARTED>>>>>>>>>>>>>>>>>>>>");

            foreach(string line in arr) {
                Console.WriteLine(line);

                ints.Add(Convert.ToInt32(line));
            }

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<STEP ONE DONE>>>>>>>>>>>>>>>>>>>>>>");

            for (int i = 0; i < ints.Count - 2; i++) {
                Console.WriteLine(i);

                sum.Add(ints[i + 2] + ints[i + 1] + ints[i]);
            }

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<STEP TWO DONE>>>>>>>>>>>>>>>>>>>>>>>");

            for(int i = 0; i < sum.Count - 1; i++) {

                Console.WriteLine("Line " + i + ": " + sum[i]);

                if(sum[i] < sum[i + 1]) {
                    res++;
                }
            }

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<DONE>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

            return res;
        }
    }
}
