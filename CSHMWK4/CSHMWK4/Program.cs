using System;

namespace CSHMWK4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit ("ten", "sweet", 10);
            f1.childP(2);

            Mango app = new Mango("one", "sour", 12, "yummy");
        }
    }
}
