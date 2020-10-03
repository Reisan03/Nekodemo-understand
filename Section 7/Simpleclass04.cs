using System;
using System.Xml.Serialization;

namespace Simplec4
{
    class simpleclass4
    {
        private int x;

        public static void Main()
        {
            simpleclass4 a = new simpleclass4();
            a.x = 10;
            Console.WriteLine(a.x);
        }
    }
}
