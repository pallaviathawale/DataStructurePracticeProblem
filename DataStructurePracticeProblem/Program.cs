﻿namespace DataStructurePracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine("Welcome to Generics Data Structures!!!\n");

            //LinkedList<int> list = new LinkedList<int>();

            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            //list.Display();


            GenericsStack<int> stack = new GenericsStack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
    
    
}