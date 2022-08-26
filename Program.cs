﻿namespace Simple_LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.Write("Select Option:\n" +
                    "1) Simple LinkedList\n" +
                    "2) LinkedList using Nodes\n" +
                    "3) LinkedList creation by appending\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LinkedList<int> a1 = new LinkedList<int>();
                        a1.AddLast(56);
                        a1.AddLast(30);
                        a1.AddLast(70);
                        foreach (int data in a1)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("| " + data + " |");
                            Console.WriteLine("-----------------");
                        }
                        break;
                    case 2:
                        LinkedList a2 = new LinkedList();
                        a2.AddNode(56);
                        a2.AddNode(30);
                        a2.AddNode(70);
                        a2.Display();
                        break;
                    case 3:
                        LinkedList a3 = new LinkedList();
                        a3.AddNode(70);
                        a3.AddNode(30);
                        a3.AddNode(56);
                        a3.ReverseList();
                        a3.Display2();
                        break;
                }
            }
        }
    }
}