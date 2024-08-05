using System;

namespace ClearTest
{
    class TryCatchFinally
    {
        public int DoIt()
        {
            int i;
            try
            {
                i = 1;
                throw new Exception();
            }
            catch (ArgumentException ex)
            {
                i = 3;
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                i = 2;
                Console.WriteLine(ex);
            }
            finally
            {
                i = 4;
            }
            // i = 5;
            return i;
        }
    }
}
