using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BaloonSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 6, 532, 23, 41, 412, 411, 4121, 5651, 867, 32532 };
            int count = 1;
            while (count != 0)
            {
                count = 0;
                int temp;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        count++;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
