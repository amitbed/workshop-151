using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{   
    public class Forum
    {
        private long id;
        private string title;
        protected List<SubForum> subForums;
        private List<long> admins;
        
        public Forum(string title, List<long> admins,long createdBy)
        {
            if (admins.Contains(createdBy))
            {
                this.id = ForumSystem.idGen.generate();
                this.subForums = new List<SubForum>();
                this.title = title;
                this.admins = admins;
            }
            else
                Console.WriteLine("You Cannot create a forum");
        }
        

        public string Title
        {
            get { return this.title; }
        }

        public long ID
        {
            get { return this.ID; }
        }

        public void enterForum()
        {
            displaySubforums();
        }

        //This method displays a forum's sub forums
        public void displaySubforums()
        {
            foreach (SubForum subForum in subForums)
            {
                Console.WriteLine(subForum.Title);
            }
        }

        public SubForum searchForum(long subForumid)
        {
            foreach (SubForum sb in subForums)
            {
                if (sb.ID == subForumid)
                    return sb;
            }

            return null;
        }

        public void showForumsMainPage()
        {
            displaySubforums();
        }

        public List<SubForum> getSubForums()
        {
            return subForums;
        }

        

        public void deleteForum(Member potentialAdmin, SubForum requestedSubForum)
        {
            if (this.admins.Contains(potentialAdmin.ID))
            {
                requestedSubForum.delete();
                this.subForums.Remove(requestedSubForum);
            }
            else
            {
                Console.WriteLine("This is not a super admin!");
            }
        }
    }
}
