using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_challege_a_01
{
    class Program
    {
        static void Main(string[] args)
        {
           // Order_List();   //Sorting a string
            //Order_List2();  //Sorting a float List
            func();           //Sort used sort()
        }
        static void Order_List()
        {
            Student s1 = new Student("zli","23");
            Student s2 = new Student("bsghar","3");
            Student s3 = new Student("ahmad","13");
            List<Student> sList = new List<Student>() {s2, s1, s3};
            List<Student> sortedlist = sList.OrderBy(o=>o.name).ToList();
            foreach(Student s in sortedlist)
            {
                Console.WriteLine(s.name+"\t"+s.rollno);
            }
            Console.ReadKey();
        }
        static void Order_List2()
        {
            Student2 s1 = new Student2(34.5f,1.4f);
            Student2 s2 = new Student2(-4.5f,2.4f);
            Student2 s3 = new Student2(0.5f,0.4f);
            List<Student2> sList = new List<Student2>() { s2, s1, s3 };
            List<Student2> sortedlist = sList.OrderBy(o=>o.GPA).ToList();
            foreach (Student2 s in sortedlist)
            {
                Console.WriteLine(s.GPA + "\t" + s.CH);
            }
            Console.ReadKey();
        }
        static void func()
        {
            List<int> n1 = new List<int>() {2,5,7,3,4,2};
            n1.Sort();
            for(int i=0;i<6;i++)
            {
                Console.Write(n1[i]);
            }
            Console.ReadKey();
        }
    }
}
