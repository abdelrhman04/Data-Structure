using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class List
    {
        Node Head;
        Node Tail;
        public List(int value)
        {
            Tail = Head = null;
        }
        public void AddList(int value)
        {
            Node New = new Node(value);
           
            if(Head == null)
            {
                Head = New;
                Tail = New;
            }
            else
            {
                Tail.Next = New;
                Tail = New;
            }

        }
    }
}
