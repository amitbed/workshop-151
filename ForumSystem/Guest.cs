using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    class Guest : User
    {
        private ForumSystem forumSystem;
        public void register()
        {
            Console.WriteLine("Hi, please enter username");
            string username = Console.ReadLine();
            while (forumSystem.searchUername(username)) // what is it?
            {               //should be used through a DB. meanwhile we need to create a 
                Console.WriteLine("Username is taken. Please choose another one");
                username = Console.ReadLine();
            }
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            string email = approveEmail();
            Member member = new Member(username, password, email);
        }

        private string approveEmail()
        {
            Console.WriteLine("Please enter email");
            string email = Console.ReadLine();
            while (email.Contains("@"))
            {
                Console.WriteLine("Email should contain a @. Please retype another one");
                email = Console.ReadLine();
            }
            //send and receive approve
            return email;
        }
    }
}
