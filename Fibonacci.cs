using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Fibonacci
{
    static class Fibonacci
    {
        public static ulong GetNMemberRecursion(int n)
        {

            if (n == 1) return 0;
            if (n == 2) return 1;

            return GetNMemberRecursion(n - 2) + GetNMemberRecursion(n - 1);
        }
        public static ulong GetNMemberNormal(int n)
        {
            return ulong.Parse(GetFibListNormal(n).Last());
        }
        public static ulong GetNMember(int n, bool recursion = false)
        {
            if (recursion)
                return GetNMemberRecursion(n);
            else
                return GetNMemberNormal(n);
        }
        private static List<string> GetFibListNormal(int n)
        {
            var fibList = new List<string>(){ "0", "1" };

            ulong[] fib = new ulong[n];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2;i < n; ++i)
            {
                fib[i] = fib[i - 2] + fib[i - 1];

                fibList.Add(fib[i].ToString());
            }

            return fibList;
        }
        private static List<string> GetFibListRecursion(int n)
        {
            var fibList = new List<string>() {};

            for (int i = 1; i <= n; ++i)
            {
                fibList.Add(GetNMember(i).ToString());
            }

            return fibList;
        }
        private static List<string> GetFibList(int n, bool recursion)
        {
            if (recursion)
                return GetFibListRecursion(n);
            else
                return GetFibListNormal(n);
        }
        public static void Print(int n, bool recursion = false)
        {
   
            Console.WriteLine(string.Join(" ", GetFibList(n, recursion)));
        }
        public static void PrintNMember(int n, bool recursion = false)
        {

            Console.WriteLine(GetNMember(n, recursion));
        }
    }
}
