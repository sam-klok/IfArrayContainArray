using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfArrayContainArray
{
    class IfArrayContainArray
    {
        static void Main(string[] args)
        {
            // [10:18 AM] Fei Cheng
            //        arrayA:[5, 1, 22, 25, 6, -1, 8, 10]
            //arrayB:[1, 6, -1, 10]
            //​[10:19 AM] Fei Cheng
            //    arrayC:[5, 25, 22, 8]



            int[] a = { 5, 1, 22, 25, 6, -1, 8, 10 };
            int[] b = { 1, 6, -1, 10 };   // O( n x m ) O (m)? 
            int[] c = { 5, 25, 22, 8 };


            Console.WriteLine("Solution 1");
            Console.WriteLine(AreArraysInclusive_Solution1(a, b));
            Console.WriteLine(AreArraysInclusive_Solution1(a, c));
            Console.WriteLine();

            Console.WriteLine("Solution 2");
            Console.WriteLine(AreArraysInclusive_Solution2(a, b));
            Console.WriteLine(AreArraysInclusive_Solution2(a, c));
            Console.WriteLine();

            //Console.WriteLine("Solution 3");
            //Console.WriteLine(AreArraysInclusive_Solution3(a, b));
            //Console.WriteLine(AreArraysInclusive_Solution3(a, c));
            //Console.WriteLine();

            Console.WriteLine("Press any(where is it?) key..");
            Console.ReadKey();
        }


        // This is very straightforward algorithm,
        // however it's not the most optimal one
        // complexity of it is O( n x (m/2) ) 
        // ..
        //
        static bool AreArraysInclusive_Solution1(int[] a, int[] b)
        {
            bool res = false;
            int pos = 0;

            for (int i = 0; i < b.Length; i++)
            {
                bool tempRes = false;
                for (int j = pos; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                    {
                        tempRes = true;
                        pos = j;
                        break;
                    }
                }

                if (!tempRes)
                    return false;

                res = tempRes;

            }

            return res;
        }


        // attempt #2
        static bool AreArraysInclusive_Solution2(int[] a, int[] b)
        {
            int matchCount = 0;
            int pos = 0;

            for (var i = 0; i < a.Length; i++)
            {
               
                for (int j = pos; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        pos = j;
                        matchCount++;
                        break;
                    }
                }

            }

            return (b.Length == matchCount);
        }


        // LINQ solution ignore the order, which we don't want
        static bool AreArraysInclusive_Solution3(int[] a, int[] b)
        {
            //return a.Any(b.Contains);

            return a.Intersect(b).Any();
        }

    }
}
