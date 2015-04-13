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

        //This method adds a forum to the main forum system
        public void addForum(Forum forum)
        {
            forums.Add(forum);
        }

        //This method displays all the forums in the system
        public void displayForums()
        {
            foreach (Forum forum in forums)
            {
                Console.WriteLine(forum.Title);
            }
        }

        //This method returns all the forums in the system
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

        public bool searchMember(long memberID)
        {
            return (members.Contains(memberID));
        }
    }
}
