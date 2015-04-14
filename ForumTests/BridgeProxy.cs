using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumSystem;

namespace ForumTests
{
    class BridgeProxy : BridgeProject
    {
        private BridgeProject real;

        public BridgeProxy()
        {
            this.real = null;
        }

        public BridgeProject setRealBridge(BridgeProject real)
        {
            this.real = real;
            return this.real;
        }

        public Forum createForum(string title, List<long> admins, long creator)
        {
            if (this.real != null)
            {
                return createForum(title, admins, creator);
            }
            else return null;
        }

        public SubForum createSubForum(string title, string parent, List<string> moderators)
        {
            if (this.real != null)
            {
                return createSubForum(title, parent, moderators);
            }
            else return null;
        }

        public void removeForum(long forumId)
        {
            if (this.real != null)
            {
                removeForum(forumId);
            }
        }

        public void removeSubForum(long subForumId)
        {
            if (this.real != null)
            {
                removeForum(subForumId);
            }
        }

        public bool login(long id, string username, string password)
        {
            if (this.real != null)
            {
                return login(id, username, password);
            }
            else
                return false;
        }

        public void logout()
        {
            if (this.real != null)
            {
                logout();
            }
        }
    }
}
