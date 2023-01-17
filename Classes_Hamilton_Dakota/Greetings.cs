using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Hamilton_Dakota
{
    class Greetings
    {
        /// <summary>
        /// 
        /// </summary> Welcome Class
        public void Welcome()
        {
            Console.WriteLine("Hello Dearest Adventurer, Welcome!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"> name of user </param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, what kind of adventures are in store today?");
        }

    }
}
