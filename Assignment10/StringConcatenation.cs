using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
   // internal class StringConcatenation
    
        public delegate string AttachStringToEachOther(string s1, string s2);

        public class A
        {
            public string ConcatStrings(string s1, string s2)
            {
                return s1 + s2;
            }
        }
    }

