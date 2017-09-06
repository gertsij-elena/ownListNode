using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownListNode
{
    class Solution
    {
        public Solution()
        {
        }

        public ListNode AddListNode(ListNode l1, ListNode l2)
        {
            ListNode l = new ListNode();
            int count = l1.Count;
            bool isAdd = false;
            int[] result = new int[count];
            foreach (int i in result)
            {
                while (count > 0)
                {
                    int r1 = l1.FindNthElementFromLast(count);
                    int r2 = l2.FindNthElementFromLast(count);
                    int r = r1 + r2;
                    if (isAdd)
                    {
                        r = r + 1;
                    }
                    if (r >= 10)
                    {
                        r = r - 10;
                        isAdd = true;
                    }
                    result[i] = r;
                    l.AddLast(result[i]);
                    count--;
                }
            }
            return l;
        }

    }
}
