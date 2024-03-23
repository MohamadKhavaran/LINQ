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
            var LR1 = Arr.ToArray();

            var R2 = (from a in Arr orderby a descending select a).ToArray();
            var LR2 = Arr.OrderByDescending(a => a).ToArray();

            var R3 = (from a in Arr orderby a ascending select a).ToArray();
            var LR3 = Arr.OrderBy(a => a).ToArray();

            var R4 = (from a in Arr where a > 40 select a).ToArray();
            var LR4 = Arr.Where(a => a > 40).ToArray();
            var LR44 = Arr.Where(a => a > 40).OrderBy(a => a).ToArray();

            // Check All of Members And Return First Of This Element ; If Not Found That Get Error
            var R5 = (from a in Arr where a == 20 select a).First();
            var LR5 = Arr.Where(a => a == 20).First();

            // Check All of Members And Return First Of This Element ; If Not Found That Get 0
            var R6 = (from a in Arr where a == 35 select a).FirstOrDefault();
            var LR6 = Arr.Where(a => a == 35).FirstOrDefault();

            // Dont Check All Members ;Navigate List to Get Element  And Return First Of This Element ; If Not Found That Get Error
            var R7 = (from a in Arr where a == 90 select a).Single();
            var LR7 = Arr.Where(a => a == 90).Single();

            // Dont Check All Members ;Navigate List to Get Element  And Return First Of This Element ; If Not Found That Get 0
            var R8 = (from a in Arr where a == 45 select a).SingleOrDefault();
            var LR8 = Arr.Where(a => a == 45).SingleOrDefault();

            var R9 = (from a in Arr select a).Count();
            var LR9 = Arr.Count();

            var R10 = (from a in Arr where a == 10 select a).Count();
            var LR10 = Arr.Where(a => a == 10).Count();

            //Check Exist Or Not Element
            var R11 = (from a in Arr where a == 60 select a).Any();
            var LR11 = Arr.Any();

            var R12 = (from a in Arr select a).Max();
            var LR12 = Arr.Max();

            var R13 = (from a in Arr select a).Min();
            var LR13 = Arr.Min();

            var R14 = (from a in Arr select a).Sum();
            var LR14 = Arr.Sum();

            List<string> Student = new List<string>();
            Student.Add("amin");
            Student.Add("Milad");
            Student.Add("Masoud");
            var R15 = (from a in Student where a.ToUpper().Contains("M") select a).ToList();
            var LR15 = Student.Where(a => a.ToUpper().Contains("M")).ToList();

            var R16 = (from a in Student where a.StartsWith("M") select a).ToList();
            var LR16 = Student.Where(a => a.StartsWith("M")).ToList();

            var R17 = (from a in Student select a.EndsWith("d")).ToList();
            var LR17 = Student.Where(a => a.EndsWith("d")).ToList();
            Console.ReadKey();
        }
    }
}
