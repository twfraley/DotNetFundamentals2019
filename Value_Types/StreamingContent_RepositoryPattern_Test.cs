using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;

namespace Value_Types
{
    [TestClass]
    public class StreamingContent_RepositoryPattern_Test
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent movie = new StreamingContent();
            movie.ContentTitle = "Infinity War";

            //--Act
            string actual = movie.ContentTitle;
            string expected = "Infinity War";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetIsMatureBoolean_ShouldReturnTrue()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;
            //--Act
            bool actual = content.IsMature;
            bool expected = true;
            //--Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            //Arrange
            StreamingContent content = new StreamingContent("Bolt","Family",1.3f,false,5);
            StreamingContent contentTwo = content;

            //Act
            string actual = content.ContentTitle;
            string expected = "Bolt";

            bool actualOne = content.IsMature;
            bool expectedOne = false;

            //Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);

        }

        [TestMethod]
        public void StreamingContentRepository_AddToList_ShouldReturnCorrectCount()
        {
            //Arrange
            StreamingContent music = new StreamingContent();
            StreamingContent movie = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            //Act
            repo.AddContentToList(music);
            repo.AddContentToList(movie);

            int actual = repo.GetStreamingContentList().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);

         }
    }
}
