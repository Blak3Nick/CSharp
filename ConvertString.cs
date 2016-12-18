using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CardGameBlake
{
    class ConvertString
    {
        int j;
        public int Convert(string input)
        {
            try
            {
                j = Int32.Parse(input);
            }
                
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return j;
        }
    }
}