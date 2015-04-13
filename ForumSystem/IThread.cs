using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IThread
    {
        string getTitle();
        List<Message> getMessages();
        int getTopicId();
    }
}
