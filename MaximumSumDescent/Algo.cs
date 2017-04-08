using System;

namespace MaximumSumDescent
{
    internal class Algo
    {
        public void Run(NakedNode[][] nodes)
        {
            for(int i=0; i<nodes.Length; i++)
            {
                for(int j=0; j<nodes[i].Length; j++)
                {
                    Console.WriteLine(nodes[i][j] != null ? nodes[i][j].Name : "_");
                }
            }

            for(int i=1; i<nodes.Length; i++)
            {
                for(int j=0; j<nodes[i].Length; j++)
                {
                    if (j == 0)
                    {
                        nodes[i][j].CumulativeValue = nodes[i-1][j].CumulativeValue + nodes[i][j].CumulativeValue;
                    }
                    else if (j == nodes[i].Length-1)
                    {
                        nodes[i][j].CumulativeValue = nodes[i-1][j-1].CumulativeValue + nodes[i][j].CumulativeValue;
                    }
                    else
                    {
                        int left = nodes[i][j].CumulativeValue + nodes[i-1][j-1].CumulativeValue;
                        int right = nodes[i][j].CumulativeValue + nodes[i-1][j].CumulativeValue;
                        nodes[i][j].CumulativeValue = Math.Max(left, right);
                    }

                    Console.Write(" <" + nodes[i][j].Name + " " + nodes[i][j].CumulativeValue + "> ");
                }
                Console.WriteLine();
            }

            int[] indices = new int[nodes.Length];
            indices[0] = 0;

            for(int i=nodes.Length-1;i>0; i--)
            {
                int max = 0;
                for(int j=0; j<nodes[i].Length-1; j++)
                {
                    if (nodes[i][j].CumulativeValue > max)
                    {
                        indices[i] = j;
                        max = nodes[i][j].CumulativeValue;
                    }
                    if (nodes[i][j+1].CumulativeValue > max)
                    {
                        indices[i] = j+1;
                        max = nodes[i][j+1].CumulativeValue;
                    }
                }
            }

            for(int z=0;z<nodes.Length;z++)
            {
                Console.WriteLine(nodes[z][indices[z]].Name);
            }
        }
    }
}
