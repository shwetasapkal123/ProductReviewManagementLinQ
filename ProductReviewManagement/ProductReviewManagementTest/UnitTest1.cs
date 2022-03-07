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
        //UC4-count each productId present in the list
        [TestMethod]
        public void TestMethodForCountingProductId()
        {            
            string expected = "1 2 2 3 3 3 4 2 5 3 6 2 7 2 8 2 9 3 10 2 11 1 ";
            string actual = ProductReviewManager.CountingProductId(products);
            Assert.AreEqual(expected,actual);   
        }
        //Uc5-Retrieving ProductID and Review
        [TestMethod]
        public void TestMethodForProductId()
        {
            string expected = "1 2 3 4 5 6 7 8 9 10 1 3 2 4 6 8 9 5 10 2 3 5 7 9 11 ";
            string actual = ProductReviewManager.RetrieveOnlyProductIdAndReviews(products);
            Assert.AreEqual(expected, actual);
        }
        //UC6-Skipping top 5 records And displaying Remaining records
        [TestMethod]
        public void TestMethodSkipTopFiveRecords()
        {
            int expected = 20;
            int actual = ProductReviewManager.SkipTopFiveRecords(products);
            Assert.AreEqual(expected, actual);
        }

    }
}
