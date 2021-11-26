using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HewidieConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> HewidieLinkedList = new LinkedList<string>();

            var HewidieNode = HewidieLinkedList.AddFirst("Man");
            HewidieLinkedList.AddAfter(HewidieNode, "Day");
            HewidieLinkedList.AddLast("Bad");
            HewidieLinkedList.AddBefore(HewidieNode, "Nice");
            HewidieLinkedList.AddLast("Null");

            Console.WriteLine("The linked List Before Deletion:  ");

            foreach (var item in HewidieLinkedList)
            {
                Console.Write(item + " ");
            }
    
            HewidieLinkedList.RemoveFirst();
            HewidieLinkedList.RemoveLast();
            HewidieLinkedList.Remove("Nice");
            
            Console.WriteLine();
            Console.WriteLine("The linked List After Deletion: ");

            foreach (var item in HewidieLinkedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
