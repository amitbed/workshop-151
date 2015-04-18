using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumSystem;
namespace ForumTests
{
    interface BridgeProject
    {
        Forum createForum(string title, List<long> admins, long creator);
        SubForum createSubForum(string title, string parent, List<string> moderators);
        //void setForumProperties(string ForumName, int moderatorsMaxNum, string format, double precentPasswordPolicy);
        void removeForum(long forumId);
        void removeSubForum(long subForumId);

        bool login(long id, string username, string password);
        void logout();

        //createThread
        //createMessege
        //de        
    }
}


////Member Interface
//virtual public string getContent();
//virtual public int getMessageId();
//virtual public DateTime getDate();
//virtual public void displayMessage();
//virtual public List<Message> getReplies();

////SubForum Interface
//virtual public string getTitle();
//virtual public List<Thread> getThreads();
//virtual public void displayThreads();
//virtual public void displayMessages();

////Forum Interface
//virtual public string getTitle();
//virtual public void displaySubForums();
//virtual public List<SubForum> getSubForums();
//virtual public void addSubForum(SubForum subforum);

////ForumSystem Interface
//virtual public ForumSystem.ForumSystem getInstance();
//virtual public void addForum(Forum forum);
//virtual public void displayForums();
//virtual public List<Forum> getForums();
