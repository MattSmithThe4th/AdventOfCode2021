using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Code {
    class Program11 {

        


        






        public int Run() {
            string[] arr = System.IO.File.ReadAllLines(@"C:\Users\Matt Smith\source\repos\AdventOfCode\AdventOfCode\txt\Day11.txt");
            int res = 0;

            for(int i = 1; i < arr.Length; i++) {

                Console.WriteLine("Line " + i + ": " + arr[i]);

                if(Convert.ToInt32(arr[i - 1]) < Convert.ToInt32(arr[i])) {
                    res++;
                }


            }

            return res;
        }







    }
}
