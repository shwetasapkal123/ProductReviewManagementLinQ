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
            /// <summary>
            /// UC2--->Retrieve Top Three Records Whose Rating is High
            /// </summary>
            [TestMethod]
            public void TestMethodForRetrieveTopThreeRecord()
            {
                int expected = 3;

                var actual = ProductReviewManager.RetrieveTopThreeRating(products);
                Assert.AreEqual(expected, actual);
            }
    }
}
