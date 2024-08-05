using System;
using System.Collections;

namespace ClearTest
{
    class EnumExperiment
    {
        [Flags]
        enum Timeslots
        {
            None = 0X0,
            Slot1 = 0X1,
            Slot2 = 0X2,
            Slot3 = 0X4,
            Slot4 = 0X8
        }

        public void MainMethod()
        {
            //Test test = new Test();
            //test.SubArray();
            //bool? u = null;
            //if (u.HasValue)
            //{
            //    Console.WriteLine(u);
            //}
            //else
            //{
            //    Console.WriteLine(u ?? false);
            //}

            //Console.ReadLine();

            //Timeslots a = Timeslots.None;
            //a = Timeslots.Slot1 | Timeslots.Slot3;
            //bool value = (a & Timeslots.Slot2) == Timeslots.Slot2;
            //a = a ^ Timeslots.Slot3;
            //Console.WriteLine(a);
            //Console.ReadLine();

            //int? i = null;
            //int q = i.Value;

            //int counter = 0;
            //Console.WriteLine(Increment(ref counter));
            //Console.WriteLine(Increment2(counter));
            //Console.WriteLine(Increment3(out counter));
            //Console.WriteLine(counter);
            //Console.ReadLine();

            Stack st = new Stack();
            st.Push(1);
            st.Push(1.1);
            st.Push('z');
            st.Push("Hello");

            foreach (var e in st)
            {
                Console.WriteLine(e);
            }
        }

        private static int Increment(ref int value)
        {
            return value += 5;
        }

        private static int Increment2(int value)
        {
            return value += 1;
        }

        private static int Increment3(out int value)
        {
            return value = 12;
        }

        public static int ParseId(string input)
        {
            int.TryParse(input, out int returvalue);
            return returvalue;
        }
    }
}
