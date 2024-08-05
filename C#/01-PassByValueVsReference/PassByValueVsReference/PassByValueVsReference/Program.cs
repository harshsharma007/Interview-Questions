using System;

namespace PassByValueVsReference
{
    public class A
    {
        public int value;

        public A()
        {
            value = 0;
        }
    }

    internal class Program
    {
        static void Increment(int b)
        {
            b++;
        }

        static void Increment(A a)
        {
            a.value++;
        }

        static void Main(string[] args)
        {
            A a = new A();
            Increment(a);
            int b = a.value;
            Increment(b);

            Console.WriteLine(a.value);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }

    /*
        The output of the code will be:

        1
        1

        Explanation:

        1. An instance of class A named `a` is created, with `value` initialized to 0.
        2. The `increment(A a)` method is called, which increments the `value` of object `a`.
        3. After calling `increment(a)`, the value of `a.value` becomes 1.
        4. The value of `a.value` is assigned to an integer variable `b`.
        5. The `increment(int b)` method is called with `b` as the argument. This method only increments the local variable `b` within its scope, which does not affect the value of `a.value`.
        6. Therefore, both `a.value` and `b` remain 1 when printed to the console.
    */
}
