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
    }
}