using System;

namespace simpleclass02
{
    class Myclass
    {
        public int x; // インスタンス変数
    }

    class Simpleclass02
    {
        public static void Main()
        {
            Myclass a, b;
            a = new Myclass(); // オブジェクト化
            b = new Myclass(); // これもオブジェクト化

            a.x = 10;
            b.x = 100;

            Console.WriteLine(a.x);
            Console.WriteLine(b.x);
        }
    }
}
