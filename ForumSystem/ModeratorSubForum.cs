using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class ModeratorSubForum : MemberSubForum
    {
        public ModeratorSubForum()
        {
        }
        public void addThread(Thread thread)
        {
            threads.Add(thread);
        }

        public void removeThread(long threadID)
        {
            int i = 0;
            foreach (Thread t in threads)
            {
                if (t.id == threadID)
                {
                    threads.RemoveAt(i);
                    break;
                }
                i = i + 1;
            }
        }
    }
}
