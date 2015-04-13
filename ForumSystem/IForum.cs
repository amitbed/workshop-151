using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IForum
    {
        string getTitle();
        void displaySubForums();
        List<SubForum> getSubForums();
        void addSubForum(SubForum subforum);
    }
}
