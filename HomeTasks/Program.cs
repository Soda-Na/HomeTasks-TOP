using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class KMP
    {
        public List<int> prefixFunc(string s)
        {
            List<int> p = new List<int>(s.Length);
            p.Add(0);
            for (int i = 1; i < s.Length; i++)
            {
                int k = p[i - 1];
                while (k > 0 && s[i] != s[k])
                    k = p[k - 1];
                if (s[i] == s[k])
                    k++;
                p.Add(k);
            }
            return p;
        }

        public List<int> kmpSearch(string s, string t)
        {
            List<int> p = prefixFunc(s);
            List<List<int>> ans = new List<List<int>>();
            int k = 0;
            int num_pattern = 0;
            for (int i = 0; i < t.Length; i++)
            {
                while (k > 0 && k < s.Length && s[k] != t[i])
                    k = p[k - 1];
                    
                if (k < s.Length && s[k] == t[i])
                    k++;
                if (k == s.Length)
                {
                    Console.WriteLine(k);
                    ans.
                    k = p[k - 1];
                }
            }
            return ans;
        }

    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            KMP kmp = new KMP();
            string s = "ab";
            string t = "ababacabacabacabaabbacaba";
            List<int> ans = kmp.kmpSearch(s, t);
            foreach (int i in ans)
                Console.WriteLine($"Pattern found on index {i}");
            Console.ReadKey();
        }
    }
}
