using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw01
{
    class hw01
    {
        static void Swap(List<int> n, int pos1, int pos2) //Swap 구현
        {
            int t1 = n.ElementAt(pos1);
            int t2 = n.ElementAt(pos2);

            n.RemoveAt(pos1);
            n.Insert(pos1, t2);
            n.RemoveAt(pos2);
            n.Insert(pos2, t1);
        }
        
        static void Main(string[] args)
        {
            Random r = new Random();
            List <int> ll = new List<int>();
            
            for (int i = 0; i < 11 ; i++)
            {
                ll.Add(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Swap(ll, r.Next(0,10-i), 10-i);
            }

            foreach (int i in ll)
                Console.Write(i + " ");
        }
    }
}
