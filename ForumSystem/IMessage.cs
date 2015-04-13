using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem;
{
    interface IMessage
    {
        string getContent();
        int getMessageId();
        DateTime getDate();
        void displayMessage();
        List<Message> getReplies();
    }
}
