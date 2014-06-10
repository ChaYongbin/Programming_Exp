using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcon
{
    class SparsMatrix
    {
        public void PrintMatrix()
        {
            int p = 1;
            double[,] m = new double[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int rid = Buffer[p].rid;
                    int cid = buffer[p].cid;
                    double val = buffer[P].val;
                    if (rid == i && cid == j)
                    {
                        Console.Write(" {0} ", val);
                        p++;
                    }
                    else
                    {
                        Console.Write(" {0} ", m[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        void sort
        {
            Array.sort(Buffer, delegate(Elem x, Elem y) {
            if (x.rid < y.rid)
        {
            return -1;

        }
            else (x.rid > y.cid)
        {

        }
        })
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SparsMatrix m new SparsMatrix(6,6);
            m
        }
    }
}
