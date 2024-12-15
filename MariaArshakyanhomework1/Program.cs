using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1.MariaArshakyan
{
    internal class Queque
    {
        public void push(List<int> que, int value, int max)
        {
            if (isfull(que, max) == 1)
            {
                Console.WriteLine("Sorry, the queue is full");

            }
            else
            {
                que.Add(value);
                Console.WriteLine("the {0} item was added to the list", value);
            }

        }

        public void peek(List<int> que)
        {
            if (isempty(que) == 1)
            {
                Console.WriteLine("Sorry, the queque is empty");
            }
            else
            {
                int value = que[0];
                Console.WriteLine(value);
            }
        }
        public void pull(List<int> que)
        {
            if (isempty(que) == 1)
            {
                Console.WriteLine("Sorry, the queque is empty");
            }
            else
            {
                int value = que[0];
                que.RemoveAt(0);
                Console.WriteLine("the {0} item was removed from the list", value);
            }
        }
        public int isfull(List<int> que, int max)
        {
            if (que.Count >= max)
            {
                return 1;
            }
            else { return 0; }
        }

        public int isempty(List<int> que)
        {
            if (que.Count == 0)
            {
                return 1;
            }
            else { return 0; }

        }
        public void printArray(List<int> array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
