using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{   
    public class Forum

    {
        public long id { get; set; }        
        public string title { get; set; }
        protected List<SubForum> subForums;
        private List<long> admins;
        public Forum()
        {

        }

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

        public SubForum searchSubForum(long subForumid)
        {
            foreach (SubForum sb in subForums)
            {
                if (sb.ID == subForumid)
                    return sb;
            }

            return null;
        }

        public void addSubForum(SubForum sf)
        {
            this.subForums.Add(sf);
        }

        public void showForumsMainPage()
        {
            displaySubforums();
        }

        public List<SubForum> getSubForums()
        {
            return subForums;
        }
    }
}
