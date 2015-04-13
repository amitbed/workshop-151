using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Message : IMessage
    {
        private int id;
        private int topicId;
        private string content;
        private DateTime date;
        private long userId;
        private List<Message> replies;

        //Overload Contructor
        public Message(int topicId, string content, long userId)
        {
            Random rnd = new Random();
            this.id = rnd.Next(2000, 20000);
            this.topicId = topicId;
            this.content = content;
            this.date = DateTime.Now;
            this.userId = userId;
            this.replies = new List<Message>();
        }
        //Member Variables
        

        //Methods
        //This method returns a message content

        public long UserID
        {
            get { return this.userId; }
        }
        
        public string getContent()
        {
            return content;
        }

        //This method returns the message id
        public int getMessageId()
        {
            return id;
        }

        //This method returns the message date
        public DateTime getDate()
        {
            return date;
        }

        //This method displays the message
        public void displayMessage()
        {
            Console.WriteLine("Message Id: " + getMessageId());
            Console.WriteLine(date);
            Console.WriteLine(content);
        }

        public void deleteMessage()
        {
            this.replies = null;
        }

        public List<Message> getReplies()
        {
            return replies;
        }
    }
}
