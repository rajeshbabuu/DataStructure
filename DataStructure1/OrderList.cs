using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    public class OrderList
    {
        public Node Head;

        public void Ordered(string str)
        {
            string text = File.ReadAllText(@"D:\RFP-244\DataStructure1\DataStructure\DataStructure1\Order.txt");

            string[] words = text.Split(' ');

            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                Node node = new Node(words[i]);

                if (this.Head == null)
                    this.Head = node;
                else

                {
                    node.next = this.Head;
                    this.Head = node;

                }

            }
            Node temp = this.Head;
            Node prev = null;
            int flag = 0;

            while (temp != null)
            {
                if (temp.Data.Equals(str))
                {
                    prev.next = temp.next;
                    flag = 1;
                }
                prev = temp;
                temp = temp.next;
            }
            if (flag == 0)
            {
                Node node = new Node(str);
                node.next = this.Head;
                this.Head = node;
            }
            Console.WriteLine("List of the searching word");
            Node node1 = this.Head;
            string[] array = new string[100];
            int j = 0;
            while (node1 != null)
            {
                array[j] = node1.Data + "  ";
                node1 = node1.next;
                j++;
            }
            string concat = string.Concat(array);
            Console.WriteLine(concat);
            File.WriteAllText(@"D:\RFP-244\DataStructure1\DataStructure\DataStructure1\OrderList.cs", concat);
        }
    }
    }

