using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    class ForumSystem : IForumSystem
    {

        private static ForumSystem forumSystem = null;
        private List<Forum> forums;
        public static IdGen idGen;
        long superAdmin;
        private List<Member> members;

        private ForumSystem() 
        {
            idGen = new IdGen();
            forums = new List<Forum>();
            Member super = new Member();
            superAdmin = super.ID;
            members.Add(super);
        }       

        public static ForumSystem getInstance()
        {
            if (forumSystem == null) 
            {
                forumSystem = new ForumSystem();
            }
            return forumSystem;   
        }

        public void addForum(string title, List<long> admins, long creator)
        {
            Forum newForum = new Forum(title, admins, creator);
            forums.Add(newForum);
        }

        public void displayForums()
        {
            foreach (Forum forum in forums)
            {
                Console.WriteLine(forum.Title);
            }
        }

        public List<Forum> getForums()
        {
            return forums;
        }

        public void printForums()
        {
            int i = 1;
            foreach (Forum forum in forums)
            {
                Console.WriteLine(String.Format("{0}.{1}", i, forum.Title));
            }
        }

        public void addMember()
        {
            members.Add(new Member());
        }

        public bool isUserNameExistes(string newUsername)
        {
            foreach (Member m in members)
            {
                if (m.UserName.Equals(newUsername))
                    return true;
            }
            return false;
        }

        public Forum searchForum(long forumId)
        {
            foreach (Forum f in forums)
            {
                if (f.ID == forumId)
                    return f;
            }
            return null;

        }

        public Member searchMember(long memberID)
        {
            foreach (Member m in members)
            {
                if (m.ID == memberID)
                    return m;
            }
            return null;
        }
    }    
}
