using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public class mainList
    {
        public List<string> ToDoList  = new List<string>();
        public mainList()
        {

        }
        public void Add(string s)
        {
            ToDoList.Add(s);
        }
        public void Remove(int x)
        {
            ToDoList.RemoveAt(x);
        }

        public void Display()
        {
            foreach(var t in ToDoList)
            {
                Console.WriteLine(t);
            }
        }
    }
}
