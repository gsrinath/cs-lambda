using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class EnumerableGenerator
    {
        public EnumerableGenerator()
        {
        }

        IEnumerable<int> GetNums(int limit = 100)
        {
            int i = 1;
            while(i <= limit)
            {
                Console.WriteLine("Generator is returning " + i);
                yield return i;
                i++;
            }
        }

        static void Main(string[] s)
        {
            EnumerableGenerator gen = new EnumerableGenerator();
            /*foreach(int i in gen.GetEven(100))
            {
                Console.WriteLine("Printing " + i);
                if (i > 10) break;
            }*/

            int sum = gen.GetNums(1000).Where(x => (x<100)).Aggregate(0,(result,x)=>result+x);
            //evens.GetEnumerator().MoveNext();
        }


    }
}
