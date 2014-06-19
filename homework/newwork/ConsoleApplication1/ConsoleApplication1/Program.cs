using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_week14
{
    class Student
    {
        public int id;
        public string name;
        public string picture;
        public Student left;
        public Student right;
        public Student(int id, string name, string picture)
        {
            this.id = id;
            this.name = name;
            this.picture = picture;
            left = null;
            right = null;
        }
        public void Add(Student s)
        {
            if (s.id < id)
            {
                if (left == null)
                {
                    left = s;
                }
                else
                {
                    left.Add(s);
                }
            }
            else if (s.id > id)
            {
                if (right == null)
                {
                    right = s;
                }
                else
                {
                    right.Add(s);
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        // 6/2 class contents
        public Student FindStudent(int id)
        {
            if (id == this.id)
            {
                return this;
            }
            else if (left == null && right == null)
            {
                Console.WriteLine("StudentFind : Not Found {0}", id);
                return null;
            }
            else if (left != null && id < this.id)
            {
                return left.FindStudent(id);
            }
            else if (right != null && id < this.id)
            {
                return right.FindStudent(id);
            }
            else
            {
                return null;
            }
        }

        public void PrintSubtree(int level)
        {

            if (left != null)
            {
                left.PrintSubtree(level + 1);
            }
            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine("({0} {1} {2})", id, name, picture);

            if (right != null)
            {
                right.PrintSubtree(level + 1); //operation is + ,not =
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("binary search tree");
            Student s = new Student(10, "kim", "asdf.jpg"); //루트(기준점)
            s.Add(new Student(3, "park", "park.jpg"));
            s.Add(new Student(14, "lee", "lee.jpg"));
            s.Add(new Student(1, "shin", "fdsa.jpg"));
            s.Add(new Student(8, "shin", "fdsa.jpg"));
            s.FindStudent(3).PrintSubtree(0);
            Console.WriteLine("                ");
            s.PrintSubtree(0);
        }
    }
}