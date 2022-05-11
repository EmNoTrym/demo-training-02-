using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_t4
{
    class StringBuild
    {
        private StringBuilder sb = new StringBuilder("Hello World!", 50);

        public string print()
        {
            return sb.ToString();
        }

        public void loopString()
        {
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
        }
    }
}
