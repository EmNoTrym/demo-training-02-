using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_t4
{
    interface IFile
    {
        //public by default
        void ReadFile();
        void WriteFile(string text);
    }
}
