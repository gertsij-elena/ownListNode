using System;

namespace ownListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            l1.AddFirst(3);
            l1.AddFirst(4);
            l1.AddFirst(2);
            Console.WriteLine();
            Console.Write("First ListNode:");
            l1.PrintList();


            ListNode l2 = new ListNode();
            l2.AddFirst(4);
            l2.AddFirst(6);
            l2.AddFirst(5);
            Console.WriteLine();
            Console.Write("Second ListNode:");
            l2.PrintList();

            Console.WriteLine();
            Console.Write("The Result:");
            Solution s = new Solution();
            ListNode res = s.AddListNode(l1, l2);
            res.PrintList();

            Console.ReadKey();
        }
    }
}
