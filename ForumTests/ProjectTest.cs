using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForumSystem;

namespace ForumTests
{
    [TestClass]
    public class ProjectTest
    {
        private BridgeProject bridge = Driver.getBridge();
        ForumSystem.ForumSystem system;
        bool firstEntry = true;
        [TestMethod]
        public void initForumTest()
        {
            SetUp();
            Assert.IsNotNull(system);
        }

        //List<UserInfo> membersList;
        //readonly User Sagi = createMember(30548, "sagiav", "sagiav@post.bgu.ac.il","gold", "maihyafa", true, null, null, null, null);
        //readonly UserInfo Amit = createMember(20566, "amitbed", "amitbed@post.bgu.ac.il","silver", "ronahayafa", true, null, null, null, null);
        //readonly UserInfo Dean = createMember(20365, "abadie", "abadie.post@post.bgu.ac.il",null , "liatush", true, null, null, null, null);


        //recipesForPassover = createSubForum(11, null, "recipesForPassover", new List<long>(20566));
        //readonly SubForum

        public virtual void SetUp()
        {
            this.bridge = Driver.getBridge();
            //setUpMembers();
            if (firstEntry == true)
            {
                setUpForum();
            }
            //setUpForumSystem();
            //setUpSubForum();
        }

        private void setUpForum()
        {
            system = ForumSystem.ForumSystem.getInstance();
            Forum Dating = bridge.createForum(1, "Dating", new List<int>(30548));
            Forum Food = bridge.createForum(2, "Food", new List<int>(20365));

            bridge.addForumToSystem(Dating);
            bridge.addForumToSystem(Food);
            firstEntry = false;
        }

        public Forum getForum(int i)
        {
            return system.getForums()[i];
        }

        public SubForum setUpSubForum(int id, string title, List<string> moderators, string parent)
        {
            return bridge.createSubForum(id, title, moderators, parent);
        }

        public void addForumToSystem(Forum forum)
        {
            bridge.addForumToSystem(forum);
        }

        public Forum CreateForum(int id, string title, List<int> admins)
        {
            return bridge.createForum(id, title, admins);
        }

        public void setForumProperties(string ForumName, int moderatorsMaxNum, string format, double precentPasswordPolicy)
        {
            bridge.setForumProperties(ForumName, moderatorsMaxNum, format, precentPasswordPolicy);
        }

        public bool ComparerProperties(string ForumName, int moderatorsMaxNum, string format, double precentPasswordPolicy)
        {
            //TODO: add getForumByName and compare its properties
            return true;
        }

        public void addSubForumToForum(Forum forum, SubForum sf)
        {
            bridge.addSubForumToForum(forum, sf);
        }

        //private void setUpForumSystem()
        //{
        //    ForumSystem.ForumSystem system = ;
        //    //forumSystem.forums = forums;
        //}

        //private void setUpMembers()
        //{
        //    //TODO: add an interface for add member method

        //    membersList.Add(Sagi);
        //    membersList.Add(Amit);
        //    membersList.Add(Dean);


        //}
        //public static SubForumInfo createSubForum(int id, List<ThreadInfo> threds, string title, List<long> moderatorsID)
        //{
        //    SubForumInfo currSubForum = new SubForumInfo();
        //    currSubForum.id = id;
        //    currSubForum.threads = threds;
        //    currSubForum.title = title;
        //    currSubForum.moderatorIDs = moderatorsID;

        //    return currSubForum;

        //}


        //public static ForumInfo createForum(int id, List<SubForumInfo> subForums, string title, List<long> adminsID)
        //{
        //    ForumInfo currForum = new ForumInfo();
        //    currForum.id = id;
        //    currForum.subForums = subForums;
        //    currForum.title = title;
        //    currForum.adminIDs = adminsID;

        //    return currForum;
        //}

        //public static UserInfo createMember(long id, string userName, string email,String memberType, string password, bool active, List<UserInfo> friends, List<ThreadInfo> myThreads, List<int> mySubForums, List<int> myForum)
        //{
        //    UserInfo currUser = new UserInfo();
        //    currUser.id = id;
        //    currUser.userName = userName;
        //    currUser.email = email;
        //    currUser.password = password;
        //    currUser.memberType = memberType;
        //    currUser.active = active;
        //    currUser.friends = friends;
        //    currUser.myForums = myForum;
        //    currUser.mySubForum = mySubForums;
        //    currUser.myThreads = myThreads;

        //    return currUser;
        //}
    }
}
