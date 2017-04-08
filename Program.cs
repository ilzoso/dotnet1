using System;
using System.Collections.Generic;
using System.Linq;

using MaximumSumDescent;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ass = args.Where(a => a != null).SingleOrDefault();
            Console.WriteLine("Hello World! " + ass);

            Node root = new Node(5, "R");
            Node n21 = new Node(5, "A");
            Node n22 = new Node(5, "B");
            Node n31 = new Node(5, "C");
            Node n32 = new Node(5, "D");
            Node n33 = new Node(5, "E");
            Node n41 = new Node(5, "F");
            Node n42 = new Node(5, "G");
            Node n43 = new Node(5, "H");
            Node n44 = new Node(5, "I");
            Node n51 = new Node(5, "J");
            Node n52 = new Node(5, "K");
            Node n53 = new Node(5, "L");
            Node n54 = new Node(5, "M");
            Node n55 = new Node(5, "N");
            root.Children.Add(n21);
            root.Children.Add(n22);
            n21.Parents.Add(root);
            n21.Children.Add(n31);
            n21.Children.Add(n32);
            n22.Parents.Add(root);
            n22.Children.Add(n32);
            n22.Children.Add(n33);
            n31.Parents.Add(n21);
            n31.Children.Add(n41);
            n31.Children.Add(n42);
            n32.Parents.Add(n21);
            n32.Parents.Add(n22);
            n32.Children.Add(n42);
            n32.Children.Add(n43);
            n33.Parents.Add(n22);
            n33.Children.Add(n43);
            n33.Children.Add(n44);
            n41.Parents.Add(n31);
            n41.Children.Add(n51);
            n41.Children.Add(n52);
            n42.Parents.Add(n31);
            n42.Parents.Add(n32);
            n42.Children.Add(n52);
            n42.Children.Add(n53);
            n43.Parents.Add(n32);
            n43.Parents.Add(n33);
            n43.Children.Add(n53);
            n43.Children.Add(n54);
            n44.Parents.Add(n33);
            n44.Children.Add(n54);
            n44.Children.Add(n55);
            n51.Parents.Add(n41);
            n52.Parents.Add(n41);
            n52.Parents.Add(n42);
            n53.Parents.Add(n42);
            n53.Parents.Add(n43);
            n54.Parents.Add(n43);
            n54.Parents.Add(n44);
            n55.Parents.Add(n44);
            Graph g = new Graph(root);
            Dynamic algo = new Dynamic(g);
            //LinkedList<Node> result = algo.Calculate();

            //LinkedListNode<Node> n = result.First;
            //while(n != null)
            //{
                //Console.WriteLine("--> " + n.Value.Value);
                //n = n.Next;
            //}

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

