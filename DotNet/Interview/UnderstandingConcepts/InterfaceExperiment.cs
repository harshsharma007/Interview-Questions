using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTest
{
    interface ISample
    {
        void Print(string val = "Interface Executed");
    }

    public class Sample : ISample
    {
        public void Print(string val = "Class Executed")
        {
            Console.WriteLine(val);
        }
    }

    public class A
    {
        public virtual void Method()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void Method()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public new void Method()
        {
            Console.WriteLine("C");
        }
    }

    public class TestClassNew
    {
        public static int MyVal = 15;

        public void Increment()
        {
            MyVal += 5;
        }

        public void PrintValue()
        {
            Console.WriteLine(MyVal);
        }
    }

    public interface Test
    {
        void Test();
    }

    public class TestClassA : Test
    {
        public virtual void Test()
        {
            Console.WriteLine("TestClassA");
        }
    }

    public class TestClassB : TestClassA
    {
        public override void Test()
        {
            Console.WriteLine("TestClassB");
        }
    }

    class InterfaceExperiment
    {
        public void MainMethod()
        {
            TestClassNew t1 = new TestClassNew();
            TestClassNew t2 = new TestClassNew();

            t1.PrintValue();
            t2.PrintValue();

            t1.Increment();
            t2.Increment();

            t1.PrintValue();
            t2.PrintValue();

            A obj = new B();
            obj.Method();

            obj = new C();
            obj.Method();

            obj = new A();
            obj.Method();

            Sample s = new Sample();
            s.Print();

            ISample i = s;
            i.Print();

            Console.ReadLine();
        }
    }
}
