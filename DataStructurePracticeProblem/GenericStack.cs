using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePracticeProblem
{
    public class GenericsStack<T>
    {
        private Node<T> top;

        public GenericsStack()
        {
            top = null;
        }

        private void IfTopisNull()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty!!!");
            }
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = top;
            top = newNode;
        }

        public void Display()
        {
            IfTopisNull();
            Node<T> temp = top;
            while (temp != null)
            {
                Console.WriteLine("" + temp.data + "");
                temp = temp.next;
            }
        }
    }
}
