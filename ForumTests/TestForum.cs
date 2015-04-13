using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForumSystem;
using System.Collections.Generic;

namespace ForumTests
{
    [TestClass]
    public class TestForum : ProjectTest
    {
        private Forum Dating, Food;
        ForumSystem.ForumSystem system = ForumSystem.ForumSystem.getInstance();

        public override void SetUp()
        {
            base.SetUp();
            setUpForum();
        }

        private void setUpForum()
        {
            system = ForumSystem.ForumSystem.getInstance();
            Dating = getForum(0);
            Food = getForum(1);
        }

        [TestMethod]
        public void AddForumTest()
        {
            SetUp();
            int initCapacity = system.getForums().Count;
            Forum Sport = CreateForum(13, "Sport", null);
            addForumToSystem(Sport);
            int afterCapacity = system.getForums().Count;
            bool ans = false;
            if (afterCapacity == initCapacity + 1)
            {
                ans = true;
            }
            Assert.IsTrue(ans);
        }

        [TestMethod]
        public void AddForumFalseTest()
        {
            int initCapacity = system.getForums().Count;
            Forum Sport = CreateForum(13, "Sport", null);
            addForumToSystem(Sport);
            int afterCapacity = system.getForums().Count;
            bool ans = false;
            if (afterCapacity != initCapacity + 1)
            {
                ans = true;
            }
            Assert.IsFalse(ans);
        }

        [TestMethod]
        public void setForumPropertiesTest()
        {
            setForumProperties("Sport", 5 , "CapsLock", 70);
            bool ans = false;
            if (ComparerProperties("Sport", 5, "CapsLock", 70))
            {
                ans = true;
            }
            Assert.IsTrue(ans);
        }
    }
}
