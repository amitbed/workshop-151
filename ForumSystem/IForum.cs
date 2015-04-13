using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    interface IForum
    {
        string getTitle();
        void displaySubForums();
        List<SubForum> getSubForums();
        void addSubForum(SubForum subforum);
    }
}
