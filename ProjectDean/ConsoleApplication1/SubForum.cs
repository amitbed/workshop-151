using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SubForum
    {
        private long id;
        private string title;
        private List<Thread> threads;
        private List<string> moderators;
        private ForumSystem fs;

        public SubForum(string title, List<string> moderators, string parent)
        {
            this.id = ForumSystem.idGen.generate();
            this.threads = new List<Thread>();
            this.title = title;
            this.moderators = moderators;
        }
        
        //Member Variables
        
        //Methods
        //This method returns the thread title
        public string getTitle()
        {
            return title;
        }
       
        //This method returns all threads in the subForum
        public List<Thread> getThreads()
        {
            return threads;
        }

        //This method displays a sub-forum's threads
        public void displayThreads()
        {
            foreach (Thread thread in threads)
            {
                Console.WriteLine(thread.getTopicId() + ". " + thread.getTitle());
            }
        }

        public void delete()
        {
            this.id = 0;
            this.moderators = null;
            this.threads = null;
            this.title = "";
        }

        public void sendComplaint(int admin, long memberId)
        {
            foreach (Thread thread in threads){
                List<Message> messages = thread.getMessages();
                foreach (Message m in messages){
                    if (m.ID==memberId)
                        Console.WriteLine("complaint sent");
                }
            }
        }
    }
}
