using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem
{
    public class IdGen
    {
        private long forumId;
        private long subForumId;
        private long ThreadId;
        private long MessageId;
        private long MemberId;

        public IdGen()
        {
            this.forumId = 0;
            this.subForumId = 0;
            this.ThreadId = 0;
            this.MessageId = 0;
            this.MemberId = 0;
        }

        public long generateforumID()
        {
            this.forumId++;
            return forumId;
        }
        public long generateSubforumID()
        {
            this.subForumId++;
            return subForumId;
        }
        public long generateThreadID()
        {
            this.ThreadId++;
            return ThreadId;
        }

        public long generateMessageID()
        {
            this.MessageId++;
            return MessageId;
        }

        public long generateMemberID()
        {
            this.MemberId++;
            return MemberId;
        }

    }
}
