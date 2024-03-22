using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ Project in Visual Studio
            int[] Arr = { 10, 10, 35, 60, 80, 15, 30, 20, 45, 90 };
            var R1 = (from a in Arr select a).ToArray();
            var R2 = (from a in Arr orderby a descending select a).ToArray();
            var R3 = (from a in Arr orderby a ascending select a).ToArray();
            var R4 = (from a in Arr where a > 40 select a).ToArray();
            // Check All of Members And Return First Of This Element ; If Not Found That Get Error
            var R5 = (from a in Arr where a == 20 select a).First();
            // Check All of Members And Return First Of This Element ; If Not Found That Get 0
            var R6 = (from a in Arr where a == 35 select a).FirstOrDefault();
            // Dont Check All Members ;Navigate List to Get Element  And Return First Of This Element ; If Not Found That Get Error
            var R7 = (from a in Arr where a == 90 select a).Single();
            // Dont Check All Members ;Navigate List to Get Element  And Return First Of This Element ; If Not Found That Get 0
            var R8 = (from a in Arr where a == 45 select a).SingleOrDefault();
            var R9 = (from a in Arr select a).Count();
            var R10 = (from a in Arr where a == 10 select a).Count();
            //Check Exist Or Not Element
            var R11 = (from a in Arr where a == 60 select a).Any();
            var R12 = (from a in Arr select a).Max();
            var R13 = (from a in Arr select a).Min();
            var R14 = (from a in Arr select a).Sum();
            Console.ReadKey();
        }
    }
}
