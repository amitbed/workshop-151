using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForumSystem;

namespace ForumTests
{
    public class realProject : BridgeProject
    {
        ForumSystem.ForumSystem system = ForumSystem.ForumSystem.getInstance();

        public Forum createForum(string title, List<long> admins, long creator)
        {
            return system.searchForum(system.addForum(title, admins, creator));
        }

        public SubForum createSubForum(string title, string parent, List<string> moderators)
        {
            AdminForum currForum = (ForumSystem. AdminForum)system.searchForum(parent);
            long subForumId = currForum.createSubForum(title, parent, moderators);
            return currForum.searchSubForum(subForumId);
        }

        public void removeForum(long forumId)
        {
            throw new NotImplementedException();
        }

        public void removeSubForum(long subForumId)
        {
            throw new NotImplementedException();
        }

        public bool login(long id, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void logout()
        {
            throw new NotImplementedException();
        }
    }
}
