using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepoTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBool()
        {
            StreamingContent content = new StreamingContent();//breakpoint here to test
            StreamingContentRepository repo = new StreamingContentRepository();
            bool addResult = repo.AddContentToDirectory(content);
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectList()//variables inside method cannot be called outside method
        {
            StreamingContent testContent = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(testContent);
            List<StreamingContent> testList = repo.GetContent();
            bool directoryHasContent = testList.Contains(testContent);
            Assert.IsTrue(directoryHasContent);
        }
    }
}