using System;

namespace noreturnvalue.cs
{
    class kakeibo
    {
        private int total = 0;

        public void Nyukin(int en)
        {
            total += en;
            Console.WriteLine("{0}円を入金しました", en);
            return;
        }

        public void shishutu(int en)
        {
            if (total < en)
            {
                Console.WriteLine("残高が足らん 残高:{0}", total);
            }
            else
            {
                total -= en;
                Console.WriteLine("{0}円支出しといた", en);
                return;
            }
        }

        public void GetTotal()
        {
            Console.WriteLine("{0}円なんやで",total);
        }
    }
    class NoReturnValue
    {
        public static void Main()
        {
            kakeibo k = new kakeibo();

            k.GetTotal();
            k.Nyukin(10000);
            k.shishutu(9000);
            k.shishutu(6000);
            k.GetTotal();
        }
    }
}
