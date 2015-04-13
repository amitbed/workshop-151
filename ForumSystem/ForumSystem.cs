using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class ForumSystem
    {
        //Default Constructor
        private ForumSystem()
        {
            forums = new List<Forum>();
        }

        //Member Variables
        private static ForumSystem forumSystem = null;
        private List<Forum> forums;

        //Methods
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
                Console.WriteLine(forum.getTitle());
            }
        }

        //This method returns all the forums in the system
        public List<Forum> getForums()
        {
            return forums;
        }
    }
}
