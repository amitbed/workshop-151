using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface ISubForum
    {
        string getTitle();
        List<Thread> getThreads();
        void displayThreads();
        void displayMessages();
    }
}
