using System;

namespace Labb_5___Generic_class
{
    public class Check<T>
    {
        public bool check;
        public bool toCheck(T x, T y)
        {
            return x.Equals(y);            
        }
    }  
    public class Check1<T> : Check<T>
    {        
    }
    public class Check2<T> : Check<T>
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Check1<string> ch1 = new Check1<string>();        
            if (ch1.toCheck("test", "test"))//Equal
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }


            Check1<string> ch2 = new Check1<string>();        
            if (ch2.toCheck("test", "testing"))//not equal
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }


            Check2<int> ch3 = new Check2<int>();         
            if (ch3.toCheck(1, 1))//equal
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }


            Check2<int> ch4 = new Check2<int>();            
            if (ch4.toCheck(10, 20))//not equal
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }
        }
    }
}
