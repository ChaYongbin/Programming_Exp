using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 o Reverse
  - 주어진 Polynomial 의 출력을 제어하는 알고리즘을 작성하시오
    + 기본문제: 출력 순서를 역순으로 바꾸는 함수 Reverse() 를
      작성하시오.
 */

namespace Polynomial
{
    class homework6
    {
        class Term
        {
            public double coef;
            public int exp;
            public Term next;
        }
        
        class Polynomial
        {
            public Term first;
            public Polynomial()
            {
                first = null;
            }
            public Polynomial Simplify()
            {
                Polynomial resPoly = new Polynomial();

                for (Term t = first; t != null; t = t.next)
                {
                    double coef = t.coef;
                    int exp = t.exp;
                    for (Term s = t.next; s != null; s = s.next)
                    {
                        if (exp == s.exp)
                        {
                            coef += s.coef;
                            s.coef = 0;
                        }
                    }
                    if (coef != 0)  
                    {
                        resPoly.AddTerm(coef, exp);
                    }
                }
                return resPoly; 
            }
            
            public void AddTerm(double coef, int exp)
            {
                Term t = new Term();
                t.coef = coef;
                t.exp = exp;

                if (first == null)
                {
                    first = t;
                    t.next = null;
                }
                else
                {
                    t.next = first;
                    first = t;
                }
            }
            public void PrintPoly()
            {
                Console.WriteLine("PrintPolynomial : TestText");
                for (Term t = first; t != null; t = t.next)
                {
                    Console.Write("({0}, {1} ) + ", t.coef, t.exp);
                }
                Console.WriteLine();
            }
            public Polynomial Reverse() //주어진 Polynomial 의 출력을 제어하는 알고리즘을 작성하시오
            {
                Polynomial s = new Polynomial();

                for (Term t = first; t != null; t = t.next)
                {
                    double coef = t.coef;
                    int exp = t.exp;
                    s.AddTerm(coef, exp);
                }
                return s;
            }
            static void Main(string[] args)
            {
                Polynomial p = new Polynomial();
                p.AddTerm(1, 2);
                p.AddTerm(-1, 1);
                p.AddTerm(-1, 1);
                p.AddTerm(-1, 0);
                p.PrintPoly();
                Console.WriteLine("-------------------");
                p.Simplify().PrintPoly();
                Console.WriteLine("-------------------");
                p.Simplify().Reverse().PrintPoly();
            }
        }
    }
}