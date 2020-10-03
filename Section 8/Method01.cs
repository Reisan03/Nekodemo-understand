using System;

namespace Method01
{
    class Myclass
    {
        public int Add(int x, int y)
        {
            int z;
            z = x + y;
            return z;
        }
    }

    class Method01
    {
        public static void Main()
        {
            Myclass a = new Myclass();
            int sum;
            sum = a.Add(100, 200);
            Console.WriteLine(sum);
        }
    }
}
