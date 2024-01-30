using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public List<int> PrefixFunc(string s)

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

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
