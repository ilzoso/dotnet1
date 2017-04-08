using System;
using System.Linq;

using MaximumSumDescent;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NakedNode[][] nodes = new NakedNode[5][];

            nodes[0] = new NakedNode[1];
            nodes[1] = new NakedNode[2];
            nodes[2] = new NakedNode[3];
            nodes[3] = new NakedNode[4];
            nodes[4] = new NakedNode[5];
            nodes[0][0] = new NakedNode(5, "A");
            nodes[1][0] = new NakedNode(7, "B");
            nodes[1][1] = new NakedNode(2, "C");
            nodes[2][0] = new NakedNode(4, "D");
            nodes[2][1] = new NakedNode(8, "E");
            nodes[2][2] = new NakedNode(3, "F");
            nodes[3][0] = new NakedNode(2, "G");
            nodes[3][1] = new NakedNode(6, "H");
            nodes[3][2] = new NakedNode(9, "I");
            nodes[3][3] = new NakedNode(4, "J");
            nodes[4][0] = new NakedNode(7, "K");
            nodes[4][1] = new NakedNode(2, "L");
            nodes[4][2] = new NakedNode(5, "M");
            nodes[4][3] = new NakedNode(3, "N");
            nodes[4][4] = new NakedNode(6, "O");

            Algo algorithm = new Algo();
            algorithm.Run(nodes);
        }
    }
}

