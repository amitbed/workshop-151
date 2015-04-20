using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class AdminForum : Forum
    {
        public AdminForum()
        {
      
        }

        public void removeSubForum(long forumID)
        {
            foreach (SubForum sb in subForums)
            {
                if (sb.ID == forumID)
                    subForums.Remove(sb);
            }
        }

        public long createSubForum(string title, string parent, List<string> moderators)
        {
            SubForum subForum = new SubForum(title, moderators, parent);
            ForumSystem forumSystem = ForumSystem.getInstance();
            Forum f=forumSystem.searchForum(parent);
            if (f!=null)
            {
                SubForum sb = f.searchSubForum(subForum.ID);
                if (sb == null)
                    f.addSubForum(subForum);
            }
            return subForum.ID;
        }
    }
}
