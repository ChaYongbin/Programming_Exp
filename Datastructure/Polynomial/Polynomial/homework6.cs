using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 o Simplification
  - Polynomial class 를 작성하고 단순화 알고리즘을 작성하시오
    + 기본문제: Term 을 삭제할 필요가 있을 때 coefficient 를 0 으로 지정한 후에
      일괄삭제하는 방식으로 작성하시오
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
                    if (coef != 0)  // Term 을 삭제할 필요가 있을 때 coefficient 를 0 으로 지정한 후에 일괄삭제하는 방식으로 작성하시오
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
            }
        }
    }
}
