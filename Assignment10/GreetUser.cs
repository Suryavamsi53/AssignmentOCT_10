using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //internal class GreetUserusing {

        public delegate void GreetUser(string name);

        public class Greeting
        {
            public event GreetUser UserGreeted;

            public void Greet(string name)
            {
                UserGreeted?.Invoke(name);
            }
        }
    

        }
    

