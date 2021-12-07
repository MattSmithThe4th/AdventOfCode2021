using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Code {
    class Program22 {
        public int Run() {
            string[] arr = System.IO.File.ReadAllLines(@"C:\Users\Matt Smith\source\repos\AdventOfCode\AdventOfCode\txt\Day21.txt");
            int hpos = 0;
            int vpos = 0;
            int aim = 0;
            string[] tmp;

            foreach(string line in arr) {

                tmp = line.Split(' ');

                switch(tmp[0]) {

                    case "forward":
                        hpos += Convert.ToInt32(tmp[1]);

                        vpos += Convert.ToInt32(tmp[1]) * aim;
                        break;

                    case "down":
                        aim += Convert.ToInt32(tmp[1]);
                        break;

                    case "up":
                        aim -= Convert.ToInt32(tmp[1]);
                        break;


                    default:
                        Console.WriteLine("SHIT BROKE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        break;
                }


            }

            return hpos * vpos;
        }
    }
}
