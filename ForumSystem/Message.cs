using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class Message
    {
        public long id { get; set; }
        public long topicID { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public long userId { get; set; }
        private List<Message> replies;

        //Overload Contructor
        public Message(long topicId, string content, long userId)
        {
            Random rnd = new Random();
            this.id = rnd.Next(2000, 20000);
            this.topicID = topicId;
            this.content = content;
            this.date = DateTime.Now;
            this.userId = userId;
            this.replies = new List<Message>();
        }
        //Member Variables
        

        //Methods
        
        //This method returns the message date

        //This method displays the message
        public void displayMessage()
        {
            Console.WriteLine("Message Id: " + id);
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
