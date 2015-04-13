using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class ModeratorSubForum : SubForum
    {
        public void addThread(long member, Thread thread)
        {
            threads.Add(thread);
        }

        public void removeThread(long threadID)
        {
            foreach (Thread t in threads)
            {
                if (t.getId() == threadID) { }
            }
        }
    }
}
