using System;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            SaySomething();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello World";
            return "Something";
        }
    }

    /*
        The output of the code will be:

        (Empty line)
        Hello World

        Explanation:

        1. `SaySomething()` method is called from the `Main` method.
        2. The `SaySomething()` method asynchronously waits for 5 milliseconds (`Task.Delay(5)`).
        3. While waiting, control returns to the `Main` method, which proceeds to the next line (`Console.WriteLine(result);`) without waiting for the asynchronous operation to complete.
        4. Since the `SaySomething()` method has not yet completed its asynchronous operation, the value of `result` is still `null`, so an empty line is printed.
        5. After that, the `Main` method waits for user input with `Console.ReadLine()`.
        6. Meanwhile, after the 5 milliseconds delay, the asynchronous operation completes, setting the value of `result` to "Hello World".
        7. However, since the `Main` method has already printed the value of `result` (which was `null` at that point), "Hello World" is not printed on the console immediately.
    */
}
