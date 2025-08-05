
using MyLibrary;

using ImplementationOfExtension;

namespace ImplementationOfConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 10,4,2,34,11 };
            ArrayHelper helper = new ArrayHelper(values);
            Console.WriteLine("Original array: " + string.Join(", ", helper.Values));
            helper.RotateArray(2);
            Console.WriteLine("Rotated array: " + string.Join(", ", helper.Values));
        }
    }
}