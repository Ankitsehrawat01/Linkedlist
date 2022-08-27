namespace Simple_LinkedList
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
                    "3) LinkedList creation by appending\n" +
                    "4) Insertion at a particular position in the LinkedList\n" +
                    "5) Remove first Node in the LinkedList\n");
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
                    case 4:
                        LinkedList a4 = new LinkedList();
                        a4.AddNode(56);
                        a4.AddNode(70);
                        a4.Insertatparticularposition(2, 30);
                        a4.Display();
                         break;
                    case 5:
                        LinkedList a5 = new LinkedList();
                        a5.AddNode(56);
                        a5.AddNode(30);
                        a5.AddNode(70);
                        a5.Display();
                        a5.RemoveFirstNode();
                            Console.WriteLine("First Node is removed from the linkedlist");
                        a5.Display();
                        break;
                }
            }
        }
    }
}