using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class SubForum
    {
        private long id;
        private string title;
        protected List<Thread> threads;
        private List<string> moderators;
        private ForumSystem fs;

        public SubForum(string title, List<string> moderators, string parent)
        {
            this.id = ForumSystem.idGen.generate();
            this.threads = new List<Thread>();
            this.title = title;
            this.moderators = moderators;
        }
        
        //Methods
        //This method returns the thread title
        public string Title
        {
            get { return title; }
        }
       
        //This method returns all threads in the subForum
        public List<Thread> getThreads()
        {
            return threads;
        }

        public long ID
        {
            get { return this.id; }
        }

        //This method displays a sub-forum's threads
        public void displayThreads()
        {
            foreach (Thread thread in threads)
            {
                Console.WriteLine(thread.getTopicId() + ". " + thread.getTitle());
            }
        }

        public void sendComplaint(int admin, long memberId)
        {
            foreach (Thread thread in threads){
                List<Message> messages = thread.getMessages();
                foreach (Message m in messages){
                    if (m.UserID==memberId)
                        Console.WriteLine("complaint sent");
                }
            }
        }
    }
}
