using System;
using System.Threading.Tasks.Dataflow;

namespace simplec03
{
    class Myclass
    {
        public int x; // インスタンス変数
    }
    class SimpleClass03
    {
        public static void Main()
        {
            Myclass a, b;
            a = new Myclass();
            a.x = 10;
            b = a;

            Console.WriteLine(b.x);
            b.x = 100;
            Console.WriteLine(b.x);
        }
    }
}
