using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class Thread
    {
        public long id { get; set; }        
        public string title { get; set; }
        private List<Message> messages;

        public Thread(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(1, 1000);
            this.title = title;
            this.messages = new List<Message>();
        }
        
        //Methods
        public string getTitle()
        {
            return title;
        }

        public List<Message> getMessages()
        {
            return messages;
        }

        public void enterThread()
        {
            displayMessages();
        }

        public void displayMessages()
        {
            foreach (Message message in messages)
            {
                message.displayMessage();
            }
        }

        public void deleteMessage(int messageID)
        {
            foreach (Message m in messages)
            {
                if (m.id==messageID)
                {
                    m.deleteMessage();
                    messages.Remove(m);
                }
            }
        }

        public void postReply(long messID,Message m)
        {
            foreach (Message oldMessage in messages)
            {
                if (oldMessage.id == messID)
                {
                    oldMessage.postReply(m);
                }
            }

        }
    }
}
/*
 public void postReply(long )
        {
            Console.WriteLine("Select a forum to view:");
            system.displayForums();
            string forum = Console.ReadLine();
            Console.WriteLine("Select a sub-forum to view:");
            viewSubForums(forum, system);
            string subForum = Console.ReadLine();
            Console.WriteLine("Select a Discussion ID:");
            viewDiscussions(subForum, forum, forumSystem);
            int discussionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select a message ID to reply to:");
            viewMessages(discussionId, subForum, forum, forumSystem);
            int messageId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Message Content:");
            string content = Console.ReadLine();
            Message message = new Message(messageId, content, id);
            foreach (Forum forumName in forumSystem.getForums())
            {
                if (String.Equals(forum, forumName.title))
                {
                    foreach (SubForum subForumName in forumName.getSubForums())
                    {
                        if (String.Equals(subForum, subForumName.Title))
                        {
                            foreach (Thread thread in subForumName.getThreads())
                            {
                                if (discussionId == thread.id)
                                {
                                    foreach (Message threadMessage in thread.getMessages())
                                    {
                                        if (messageId == threadMessage.id)
                                        {
                                            threadMessage.getReplies().Add(message);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
*/