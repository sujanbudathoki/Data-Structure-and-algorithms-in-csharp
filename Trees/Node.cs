using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Trees
{
   public class Node
    {
        //Data
        public int IData { get; set; }//key

        public int dData { get; set; }//data
   
        //Left Child
        public Node LChild { get; set; }
        //Right Child
        public Node RChild { get; set; }
        //Node
        public Node()
        {
            IData = 0;
            dData = 0;
        }
        //Display
        public void Display()
        {
            Console.WriteLine(IData);
        }//End of Display()

    }//End of Node Class
}
