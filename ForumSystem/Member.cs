using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class Member : User
    {
        public long id { get; set; }
        public long enter;
        public string username { get; set; }
        private string email;
<<<<<<< Updated upstream
        public string password { get; set; }
        private bool isActive;
=======
        public ForumSystem system = ForumSystem.getInstance();
        public string password { get; set; }
        public bool isActive
        {
            get { return isActive; }
            set
            {
                if (value)
                {
                    enter = DateTime.Now.Hour;
                }
                else
                {
                    timeLoggedIn +=DateTime.Now.Hour- enter;
                    enter = 0;
                }
            }
        }
>>>>>>> Stashed changes
        private List<long> myFriends;
        private List<long> myThreads;
        private List<long> mySubForums;
        private List<long> myForums;
        //private double seniority;
        private double timeLoggedIn;
        //private int numberOfMessagesLastYear;

        public Member()
        {
        }
        public Member(string username, string password, string emailAddress)
        {
            this.username = username;
            this.password = password;
            this.email = emailAddress;
            this.timeLoggedIn = 0;
            this.id = ForumSystem.idGen.generate();
            this.isActive = true;
            this.myForums = new List<long>();
            this.mySubForums = new List<long>();
            this.myThreads = new List<long>();
            this.myFriends = new List<long>();
        }

        //This method creates a sub-forum
       

        //This method shows all sub forums of a given forum
        public void viewSubForums(string forumName)
        {
            foreach (Forum forum in system.getForums())
            {
                if (String.Equals(forumName, forum.title))
                {
                    forum.displaySubforums();
                }
            }
        }

        //This method shows all discussions of a given sub-forum
        public void viewDiscussions(string subForumName, string parent)
        {
            foreach (Forum forum in system.getForums())
            {
                if (String.Equals(parent, forum.title))
                {
                    foreach (SubForum subForum in forum.getSubForums())
                    {
                        if (String.Equals(subForumName, subForum.Title))
                        {
                            subForum.displayThreads();
                        }
                    }
                }
            }
        }

        //This method displays messages of a thread
        public void viewMessages(int threadId, string subForumName, string parent)
        {
            foreach (Forum forum in system.getForums())
            {
                if (String.Equals(parent, forum.title))
                {
                    foreach (SubForum subForum in forum.getSubForums())
                    {
                        if (String.Equals(subForumName, subForum.Title))
                        {
                            foreach (Thread thread in subForum.getThreads())
                            {
                                if (threadId == thread.id)
                                {
                                    thread.displayMessages();
                                }
                            }
                        }
                    }
                }
            }
        }

        //This method displays a message's replies
        public void displayReplies(string forumName, string subForumName, int discussionId, int messageId)
        {
            foreach (Forum forum in system.getForums())
            {
                if (String.Equals(forumName, forum.title))
                {
                    foreach (SubForum subForum in forum.getSubForums())
                    {
                        if (String.Equals(subForumName, subForum.Title))
                        {
                            foreach (Thread thread in subForum.getThreads())
                            {
                                if (discussionId == thread.id)
                                {
                                    foreach (Message message in thread.getMessages())
                                    {
                                        if (messageId == message.id)
                                        {
                                            foreach (Message reply in message.getReplies())
                                            {
                                                reply.displayMessage();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        

        public void logut()
        {
            this.isActive = false;
        }
        public void postReply(long id)
        {
            Console.WriteLine("Select a forum to view:");
            forumSystem.displayForums();
            string forum = Console.ReadLine();
            Console.WriteLine("Select a sub-forum to view:");
            viewSubForums(forum, forumSystem);
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
    }
}