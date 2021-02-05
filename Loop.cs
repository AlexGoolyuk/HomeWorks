using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public class Loop
    {
        public bool answer;
        public string tmp;
        public string tips;
        public int removeIndex;
        public string key;
        mainList mainList = new mainList();
        public Loop()
        {
            
            answer = true;
            while(answer)
            {
                Console.Clear();
                Console.WriteLine("A - to add; R - to remove; D - to display;");
                key = Console.ReadLine();
                choice(key);
                Console.WriteLine("Continue?(1/0:)");
                tmp = Console.ReadLine();
                if (tmp == "0")
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }

            }
        }

        public void choice(string x)
        {

            switch (x)
            {
                case "A":
                    Console.Clear();
                    Console.WriteLine("Enter new tips:");
                    tips = Console.ReadLine();
                    mainList.Add(tips);
                    Console.WriteLine("Tips added");
                    break;
                case "R":
                    Console.Clear();
                    Console.WriteLine("Enter tip to remove:");
                    removeIndex = Convert.ToInt32(Console.ReadLine());
                    mainList.Remove(removeIndex);
                    Console.WriteLine("Tip removed.");
                    break;
                case "D":
                    Console.Clear();
                    mainList.Display();
                    break;
                default:
                    break;
            }
        }


    }
}
