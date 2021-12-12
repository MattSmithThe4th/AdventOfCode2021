using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Code {
    class Program31 {
        //this is way more scuffed than it had to be
        public int Run() {
            string[] arr = System.IO.File.ReadAllLines(@"C:\Users\Matt Smith\source\repos\AdventOfCode\AdventOfCode\txt\Day31.txt");
            List<int> gammaList = new();
            string gamma = "";
            string epsilon = "";
            string base10gamma;
            string base10epsilon;
            int fromBase = 2;
            int toBase = 10;

            for(int i = 0; i < arr[0].Length; i++) {
                int one = 0;
                int zero = 0;
                foreach(string str in arr) {
                    if(str[i] == '1') {
                        one++;
                    } else {
                        zero++;
                    }
                }
                if(one > zero) {
                    gammaList.Add(1);
                } else {
                    gammaList.Add(0);
                }
            }



            foreach(int i in gammaList) {
                gamma += i.ToString();
                if(i == 1) {
                    epsilon += "0";
                } else {
                    epsilon += "1";
                }
            }

            Console.WriteLine("Gamma: " + gamma);
            Console.WriteLine("Epsilon: " + epsilon);

            base10gamma = Convert.ToString(Convert.ToInt32(gamma, fromBase), toBase);
            base10epsilon = Convert.ToString(Convert.ToInt32(epsilon, fromBase), toBase);


            return Convert.ToInt32(base10gamma) * Convert.ToInt32(base10epsilon);
        }


    }
}
