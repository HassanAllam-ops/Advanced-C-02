using System.Collections;
using System.Collections.Generic;
namespace Advanced_C__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter N And Q");
            //string[] Input = Console.ReadLine().Split();
            //int N = Convert.ToInt32(Input[0]);
            //int Q = Convert.ToInt32(Input[1]);
            //
            //ArrayList arrayList = new ArrayList();
            //string[] elements = Console.ReadLine().Split();
            //foreach (string s in elements)
            //{
            //    arrayList.Add(int.Parse(s));
            //}
            //
            //for (int i = 0; i < Q; i++)
            //{
            //    int X = Convert.ToInt32(Console.ReadLine());
            //    int Count = 0;
            //
            //    foreach (int Num in arrayList)
            //    {
            //        if (Num > X)
            //        {
            //            Count++;
            //        }
            //        
            //    }
            //    Console.WriteLine(Count);
            //}
            #endregion

            #region Q2
            //int n = int.Parse(Console.ReadLine());
            //
            //string[] Input = Console.ReadLine().Split();
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Input[i]);
            //}
            //
            //bool IsPalindrome = true;
            //
            //for(int i = 0; i < n/2; i++)
            //{
            //    if (array[i] != array[n - 1 - i])
            //    {
            //        IsPalindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(IsPalindrome ? "Yes" : "No");
            #endregion

            #region Q3
            //Queue<int> MyQueue = new Queue<int>();
            //MyQueue.Enqueue(10);
            //MyQueue.Enqueue(20);
            //MyQueue.Enqueue(30);
            //MyQueue.Enqueue(40);
            //
            //Console.WriteLine("Original Queue : ");
            //foreach (int i in MyQueue)
            //{
            //    Console.WriteLine(i + " ");
            //}
            //
            //ReverseQueue(MyQueue);
            //
            //Console.WriteLine("\nReversed Queue : ");
            //foreach(int i in MyQueue)
            //{
            //    Console.WriteLine(i + " ");
            //}
            #endregion

            #region Q4
            //string input = "[()]{}";
            //bool isBalanced = IsBalance(input);
            //Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
            #endregion

            #region Q5
            //int[] array = { 10, 15, 7, 10, 12, 7, 30, 31, 30, 15 };
            //int[] uniqueArray = RemoveDuplicates(array);
            //
            //Console.WriteLine("The Arrar After Remove Dublication : ");
            //
            //foreach (int num  in uniqueArray)
            //{
            //    Console.WriteLine(num + " ");
            //}
            #endregion
        }

        #region Q3 Fun
        //static void ReverseQueue<T>(Queue<T> queue)
        //{
        //
        //    Stack<T> stack = new Stack<T>();
        //
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //}

        #endregion

        #region Q4 Fun
        //static bool IsBalance(string str)
        //{ 
        //
        //  Stack<char> stack = new Stack<char>();
        //  Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        //  {
        //       {')', '('},
        //       {']', '['},
        //       {'}', '{'}
        //  };
        //
        //  foreach (char ch in str)
        //  {
        //      if (bracketPairs.ContainsValue(ch)) 
        //      {
        //          stack.Push(ch);
        //      }
        //      else if (bracketPairs.ContainsKey(ch)) 
        //      {
        //          if (stack.Count == 0 || stack.Pop() != bracketPairs[ch])
        //          {
        //              return false;
        //          }
        //      }
        //  }
        //
        //  return stack.Count == 0;
        //   
        //}
        #endregion

        #region Q5 Fun
        //static int[] RemoveDuplicates(int[] input)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int num in input)
        //    {
        //        if (!result.Contains(num))
        //        {
        //            result.Add(num);
        //        }
        //    }
        //    return result.ToArray();
        //}
        #endregion
    }
}
