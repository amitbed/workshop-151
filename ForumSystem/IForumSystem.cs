using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IForumSystem
    {
        ForumSystem getInstance();
        void addForum(Forum forum);
        void displayForums();
        List<Forum> getForums();
    }
}
