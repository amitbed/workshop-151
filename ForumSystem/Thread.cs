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
    }
}
