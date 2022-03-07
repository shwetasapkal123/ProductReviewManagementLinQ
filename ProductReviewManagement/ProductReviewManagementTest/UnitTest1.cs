using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System;
using System.Collections.Generic;

namespace ProductReviewManagementTest
{
    [TestClass]
    public class UnitTest1
    {        
            List<ProductReview> products;
            [TestInitialize]
            public void SetUp()
            {
                products = new List<ProductReview>();
            }
           
            // UC1-Adding a Productreview details in list and returns the count
            
            [TestMethod]
            public void TestMethodForAddingDetailsInList()
            {
                int expected = 25;
                int actual =ProductReviewManager.AddProductReviewToList(products).Count;
                Assert.AreEqual(expected, actual);
            }
            /// UC2--Retrieve Top Three Records Whose Rating is High           
            [TestMethod]
            public void TestMethodForRetrieveTopThreeRecord()
            {
                int expected = 3;

                var actual = ProductReviewManager.RetrieveTopThreeRating(products);
                Assert.AreEqual(expected, actual);
            }
        //UC3-retrieve all record whos rating greater than3 and id is 1 or 4 ,9
        [TestMethod]
        [TestCategory("Retrieving data whos id 1,4,9")]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            int expected = 6;
            var actual = ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(products);
            Assert.AreEqual(actual.Count, expected);
        }
    }
}
