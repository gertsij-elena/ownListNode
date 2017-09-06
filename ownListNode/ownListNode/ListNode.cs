using System;

namespace ownListNode
{
    class ListNode
    {
        private Node _head;
        private Node _tail;
        public int Count;

        public ListNode()
        { }

        public void AddLast(int data)
        {
            Node _newNode = new Node(data);
            if (_head == null)
            {
                _tail = _newNode;
                _head = _tail;
                Count++;
            }
            else
            {
                _tail.next = _newNode;
                _tail = _newNode;
                Count++;
            }
        }

        public void AddFirst(int data)
        {
            Node _newNode = new Node(data);
            if (_head == null)
            {
                _head = _newNode;
                _tail = _head;
                Count++;
            }
            else
            {
                _newNode.next = _head;
                _head = _newNode;
                Count++;
            }
        }

        public int FindNthElementFromLast(int n)
        {
            Node p1 = _head;
            Node p2 = p1;
            for (int i = 0; i < (n - 1); i++)
            {
                p2 = p2.next;
            }
            while (p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p1.val;
        }

        public void PrintList()
        {
            Node current = _head;
            if (_head == null)
                Console.WriteLine("ListNode is empty");
            else
            {
                Console.WriteLine();
                Console.Write("head:");
                while (current != null)
                {
                    Console.Write(current.val.ToString() + " ");
                    current = current.next;
                    Console.Write("->");
                }
                Console.WriteLine("tail");
            }
        }
    }
}
