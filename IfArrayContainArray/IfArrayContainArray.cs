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
            //int[] b = { 5, 25, 22, 8 };


            var r = AreArraysInclusiveSolution1(a, b);

            Console.WriteLine(r);
            Console.ReadLine();
        }

        static bool AreArraysInclusiveSolution1(int[] a, int[] b)
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

                res = tempRes;
                if (!tempRes)
                    return false;
            }

            return res;
        }
    }
}
