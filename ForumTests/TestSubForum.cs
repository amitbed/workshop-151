using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForumSystem;

namespace ForumTests
{
    /// <summary>
    /// Summary description for TestSubForum
    /// </summary>
    [TestClass]
    public class TestSubForum: ProjectTest
    {
        private BridgeProject bridge = Driver.getBridge();
        ForumSystem.ForumSystem system = ForumSystem.ForumSystem.getInstance();

        public TestSubForum()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void AddNewSubForumTest()
        {
            //base.SetUp();
            List<SubForum> FoodSubs = new List<SubForum>();
            SubForum PassoverRecepies = setUpSubForum(11, "PassoverRecepies", null, "Food");
            SubForum ChosherRecepies = setUpSubForum(12, "ChosherRecepies", null, "Food");
            FoodSubs.Add(PassoverRecepies);
            FoodSubs.Add(ChosherRecepies);
            Forum currForum = system.getForums()[1];
            addSubForumToForum(currForum, PassoverRecepies);
            addSubForumToForum(currForum, ChosherRecepies);
            Assert.IsTrue(subForumInForum(FoodSubs, currForum));
        }

        public bool subForumInForum(List<SubForum> FoodSubs, Forum Food)
        {
            bool ans = true;
            for (int i = 0; i < FoodSubs.Count; i++)
            {
                foreach (SubForum sub in Food.getSubForums())
                {
                    if (!FoodSubs.Contains(sub))
                    {
                        ans = false;
                    }
                }
            }
            return ans;
        }

        [TestMethod]
        public void removeSubForum()
        {

        }
    }
}
