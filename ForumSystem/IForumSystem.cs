using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    interface IForumSystem
    {
        ForumSystem getInstance();
        void addForum(Forum forum);
        void displayForums();
        List<Forum> getForums();
    }
}
