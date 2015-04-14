using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class ForumSystem
    {

        private static ForumSystem forumSystem = null;
        private List<Forum> forums;
        public static IdGen idGen;
        long superAdmin;
        public List<Member> members { get; set; }

        private ForumSystem() 
        {
            idGen = new IdGen();
            forums = new List<Forum>();
            Guest superGuest = new Guest();
            superGuest.register();
            members = new List<Member>();
            Member superMember = members.ElementAt(0);
            superAdmin = superMember.id;
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
                Console.WriteLine(forum.title);
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
                Console.WriteLine(String.Format("{0}.{1}", i, forum.title));
            }
        }

        public void addMember(string username, string password, string email)
        {
            members.Add(new Member(username, password, email));
        }

        public bool isUsernameExistes(string newUsername)
        {
            foreach (Member m in members)
            {
                if (m.username.Equals(newUsername))
                    return true;
            }
            return false;
        }

        public Forum searchForum(long forumId)
        {
            foreach (Forum f in forums)
            {
                if (f.id == forumId)
                    return f;
            }
            return null;

        }

        public Member searchMember(long memberID)
        {
            foreach (Member m in members)
            {
                if (m.id == memberID)
                    return m;
            }
            return null;
        }
    }    

    }
