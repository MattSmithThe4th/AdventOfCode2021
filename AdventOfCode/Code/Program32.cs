using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Code {
    class Program32 {
        public int Run() {
            string[] arr = System.IO.File.ReadAllLines(@"C:\Users\Matt Smith\source\repos\AdventOfCode\AdventOfCode\txt\Day31.txt");
            List<string> inputList = new();
            int fromBase = 2;
            int toBase = 10;

            foreach(string str in arr) {
                inputList.Add(str);
            }

            List<string> b2oxygen = OxygenRating(0, inputList);
            List<string> b2co2 = CO2Rating(0, inputList);



            Console.WriteLine("oxygen: " + b2oxygen[0]);
            Console.WriteLine("co2: " + b2co2[0]);

            string base10oxygen = Convert.ToString(Convert.ToInt32(b2oxygen[0], fromBase), toBase);
            string base10co2 = Convert.ToString(Convert.ToInt32(b2co2[0], fromBase), toBase);


            return Convert.ToInt32(base10oxygen) * Convert.ToInt32(base10co2);
        }

        private List<string> OxygenRating(int i, List<string> inputList) {
            List<string> outputList = new();

            int one = 0;
            int zero = 0;
            foreach(string str in inputList) {
                if(str[i] == '1') {
                    one++;
                } else {
                    zero++;
                }
            }

            bool scuffed = (one == zero);

            if(one > zero || scuffed) {
                foreach(string str in inputList) {
                    if(str[i] == '1') {
                        outputList.Add(str);
                    }
                }
            } else {
                foreach(string str in inputList) {
                    if(str[i] == '0') {
                        outputList.Add(str);
                    }
                }
            }

            //debug
            Console.WriteLine(i + "------------------------------------------------------");
            foreach(string str in outputList) {
                Console.WriteLine(str);
            }
            Console.WriteLine("");

            if(outputList.Count == 1) {
                return outputList;
            } else {
                return OxygenRating(i + 1, outputList);
            }
        }

        private List<string> CO2Rating(int i, List<string> inputList) {
            List<string> outputList = new();

            int one = 0;
            int zero = 0;
            foreach(string str in inputList) {
                if(str[i] == '1') {
                    one++;
                } else {
                    zero++;
                }
            }

            bool scuffed = (one == zero);

            if(scuffed) {
                foreach(string str in inputList) {
                    if(str[i] == '0') {
                        outputList.Add(str);
                    }
                }
            } else {
                if(one < zero) {
                    foreach(string str in inputList) {
                        if(str[i] == '1') {
                            outputList.Add(str);
                        }
                    }
                } else {
                    foreach(string str in inputList) {
                        if(str[i] == '0') {
                            outputList.Add(str);
                        }
                    }
                }
            }

            

            //debug
            Console.WriteLine(i + "------------------------------------------------------");
            foreach(string str in outputList) {
                Console.WriteLine(str);
            }
            Console.WriteLine("");

            if(outputList.Count == 1) {
                return outputList;
            } else {
                return CO2Rating(i + 1, outputList);
            }
        }



    }
}
