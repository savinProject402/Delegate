using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Class1();
            var b = new Class2();
            a.noth = Show;
            a.noth(b.Calc(a.NothPow, 1, 3)(2));
        }
        public static void Show(bool p) { Console.WriteLine(p); }
    }
    class Class1
    {
        public delegate void Nothing(bool b);
        public delegate int NothingInt(int x, int y);
        public static int Pow(int x, int y) { return x * y; }
        public NothingInt NothPow = Pow;
        public Nothing noth;
    }
    class Class2
    {
        public int res;
        public delegate bool resulC(int e);
        public resulC Calc(Class1.NothingInt pow, int x, int y)
        {
            resulC resul = Result;
            res = pow(x, y);
            return resul;
        }
        public bool Result(int z)
        {
            return res % z == 0;
        }
    }
}
