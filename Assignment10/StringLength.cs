using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //internal class StringLength
    


        public delegate int FindLength(string s);

        public class StringUtility
        {
            public int StringLength(string s)
            {
                return s.Length;
            }
        }
    }