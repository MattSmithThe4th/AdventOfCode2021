using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Code {
    class Program41 {
        public int Run() {
            string[] arr = System.IO.File.ReadAllLines(@"C:\Users\Matt Smith\source\repos\AdventOfCode\AdventOfCode\txt\Day41.txt");
            string[] draws = arr[0].Split(',');

            List<Board> Boards = IngestBoards(arr);

            return 0;
        }

        private List<Board> IngestBoards(string[] arr) {
            int i = 0;
            List<Node> tmpNode = new();
            List<Board> output = new();
            foreach(string str in arr) {
                if(str == "") {
                    for(int j = i; j < i + 5; j++) {
                        string[] tmp = arr[j].Split(' ');
                        int k = 0;
                        foreach(string s in tmp) {
                            tmpNode.Add(new Node(Convert.ToInt32(s), new List<int>() {k, j - i}));
                            k++;
                        }
                    }
                    output.Add(new Board(tmpNode));
                }
                i++;
            }
            return output;
        }
    }

    class Board {
        public List<Node> Tiles;

        public Board(List<Node> list) {
            Tiles = list;
        }

        public bool FindLine() {





            return false;
        }

        public void MarkNode(int num) {
            foreach(Node n in Tiles) {
                if(n.Value == num) {
                    n.Marked = true;
                }
            }
        }

        public int SumAllUnmarked() {
            int res = 0;
            foreach(Node n in Tiles) {
                if(!n.Marked) {
                    res += n.Value;
                }
            }
            return res;
        }
    }

    class Node {
        public int Value;
        public bool Marked;
        public List<int> Position;

        public Node(int value, List<int> position) {
            Value = value;
            Position = position;
            Marked = false;
        }
    }
}
