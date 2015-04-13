using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    interface IThread
    {
        string getTitle();
        List<Message> getMessages();
        int getTopicId();
    }
}
