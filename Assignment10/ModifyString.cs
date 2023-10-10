using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //internal class ModifyString
  
        public delegate string MakeFirstCharacterUppercase(string s);

        public class StringModifier
        {
            public event MakeFirstCharacterUppercase FirstCharacterUppercase;

            public string ModifyString(string s)
            {
                string result = FirstCharacterUppercase?.Invoke(s);
                return result;
            }
        }
}
