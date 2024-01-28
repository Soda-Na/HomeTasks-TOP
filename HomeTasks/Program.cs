using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 100;
            int end = 1_000_000_000;

            DateTime startDateTime = DateTime.Now;

            List<int> palindromes = GetPalindromes(start, end);

            List<List<int>> groupedByProduct = GroupNumbersByProduct(palindromes);
            List<int> theBiggestList = FindTheBiggestList(groupedByProduct);
            List<int> biggestNumbers = Get5BiggestNumbers(theBiggestList);

            foreach (var number in biggestNumbers)
            {
                Console.WriteLine(number);
            }

            DateTime endDateTime = DateTime.Now;
            TimeSpan timeSpan = endDateTime - startDateTime;

            Console.WriteLine($"Time: {timeSpan.TotalSeconds} seconds");
        }

        static List<int> GetPalindromes(int start, int end)
        {
            List<int> palindromes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPalindrome(i.ToString()))
                {
                    palindromes.Add(i);
                }
            }

            return palindromes;
        }

        static bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }

        static int GetDigitProduct(int number)
        {
            int product = 1;
            foreach (char digit in number.ToString())
            {
                int digitValue = digit - '0';
                if (digitValue != 0)
                {
                    product *= digitValue;
                }
            }
            return product;
        }

        static List<List<int>> GroupNumbersByProduct(List<int> numbers)
        {
            List<List<int>> groupedByProduct = new List<List<int>>();

            foreach (var number in numbers)
            {
                int product = GetDigitProduct(number);

                List<int> currentGroup = groupedByProduct.FirstOrDefault(group => GetDigitProduct(group[0]) == product);

                if (currentGroup == null)
                {
                    currentGroup = new List<int>();
                    groupedByProduct.Add(currentGroup);
                }

                currentGroup.Add(number);
            }

            return groupedByProduct;
        }

        static List<int> FindTheBiggestList(List<List<int>> groupedByProduct)
        {
            List<int> biggestList = new List<int>();
            foreach (var group in groupedByProduct)
            {
                if (group.Count > biggestList.Count)
                {
                    biggestList = group;
                }
            }
            return biggestList;
        }

        static List<int> Get5BiggestNumbers(List<int> numbers)
        {
            List<int> biggestNumbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int biggestNumber = numbers.Max();
                biggestNumbers.Add(biggestNumber);
                numbers.Remove(biggestNumber);
            }
            return biggestNumbers;
        }
    }
}