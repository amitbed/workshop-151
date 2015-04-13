using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    class AdminForum : Forum
    {

        public void removeSubForum(long forumID)
        {
            foreach (SubForum sb in subForums)
            {
                if (sb.ID == forumID)
                    subForums.Remove(sb);
            }
        }

        public void addSubForum(SubForum subForum)
        {
            subForums.Add(subForum);
        }
    }
}
