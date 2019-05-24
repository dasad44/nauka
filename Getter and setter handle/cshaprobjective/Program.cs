using System;

namespace cshaprobjective
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            class1.wprowadz();
            class2.dodawanie(class1.a, class1.b);
            Console.ReadKey();
        }
    }
}
