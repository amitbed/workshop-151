using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class Member : User
    {
        private long id;
        private string username;
        private string email;
        private string password;
        private bool isActive;
        private List<long> myFriends;
        private List<long> myThreads;
        private List<long> mySubForums;
        private List<long> myForums;
        private double seniority;
        private double timeLoggedIn;
        private int numberOfMessagesLastYear;
        private ForumSystem forumSystem;

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

        public long ID
        {
            get { return this.id; }
        }

        public string UserName
        {
            get { return this.username; }
        }

        public string getPassword()
        {
            return password;
        }


        //This method creates a sub-forum
        public void createSubForum(string title, string parent, List<string> moderators, ForumSystem forumSystem)
        {
            SubForum subForum = new SubForum(title, moderators, parent);
            foreach (Forum forum in forumSystem.getForums())
            {
                if (string.Equals(forum.Title, parent))
                {
                    forum.getSubForums().Add(subForum);
                }
            }
        }

        //This method shows all sub forums of a given forum
        public void viewSubForums(string forumName, ForumSystem mainForum)
        {
            foreach (Forum forum in mainForum.getForums())
            {
                if (String.Equals(forumName, forum.Title))
                {
                    forum.displaySubforums();
                }
            }
        }

        //This method shows all discussions of a given sub-forum
        public void viewDiscussions(string subForumName, string parent, ForumSystem mainForum)
        {
            foreach (Forum forum in mainForum.getForums())
            {
                if (String.Equals(parent, forum.Title))
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
        public void viewMessages(int threadId, string subForumName, string parent, ForumSystem mainForum)
        {
            foreach (Forum forum in mainForum.getForums())
            {
                if (String.Equals(parent, forum.Title))
                {
                    foreach (SubForum subForum in forum.getSubForums())
                    {
                        if (String.Equals(subForumName, subForum.Title))
                        {
                            foreach (Thread thread in subForum.getThreads())
                            {
                                if (threadId == thread.getId())
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
        public void displayReplies(ForumSystem mainForum, string forumName, string subForumName, int discussionId, int messageId)
        {
            foreach (Forum forum in mainForum.getForums())
            {
                if (String.Equals(forumName, forum.Title))
                {
                    foreach (SubForum subForum in forum.getSubForums())
                    {
                        if (String.Equals(subForumName, subForum.Title))
                        {
                            foreach (Thread thread in subForum.getThreads())
                            {
                                if (discussionId == thread.getId())
                                {
                                    foreach (Message message in thread.getMessages())
                                    {
                                        if (messageId == message.getMessageId())
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

        public void createThread(ForumSystem forumSystem)
        {
            Console.WriteLine("Select a forum to view:");
            forumSystem.displayForums();
            string forum = Console.ReadLine();
            Console.WriteLine("Select a sub-forum to view");
            viewSubForums(forum, forumSystem);
            string subForum = Console.ReadLine();
            Console.WriteLine("Enter Thread Title:");
            string threadTitle = Console.ReadLine();
            Thread thread = new Thread(threadTitle);
            Console.WriteLine("Enter Message Content:");
            string content = Console.ReadLine();
            Message message = new Message(thread.getId(), content, this.id);
            thread.getMessages().Add(message);
            foreach (Forum forumName in forumSystem.getForums())
            {
                if (string.Equals(forumName.Title, forum))
                {
                    foreach (SubForum subForumName in forumName.getSubForums())
                    {
                        if (string.Equals(subForumName.Title, subForum))
                        {
                            subForumName.getThreads().Add(thread);
                        }
                    }
                }
            }
        }

        public void postReply(ForumSystem forumSystem, string username)
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
                if (String.Equals(forum, forumName.Title))
                {
                    foreach (SubForum subForumName in forumName.getSubForums())
                    {
                        if (String.Equals(subForum, subForumName.Title))
                        {
                            foreach (Thread thread in subForumName.getThreads())
                            {
                                if (discussionId == thread.getId())
                                {
                                    foreach (Message threadMessage in thread.getMessages())
                                    {
                                        if (messageId == threadMessage.getMessageId())
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