using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewManager
    {
        // UC1: Method to add the product review into the list
        public static List<ProductReview> AddProductReviewToList(List<ProductReview> products)
        {
            //creating object of list and add data to list
           // List<ProductReview> products=new List<ProductReview>();
            try
            {
                //Adding 25 entries to list
                products.Add(new ProductReview() { ProductId = 1, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 2, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 3, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 5, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 6, UserId = 6, Review = "Bad", Rating = 2, IsLike = false });
                products.Add(new ProductReview() { ProductId = 7, UserId = 7, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 15, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 9, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 10, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 1, UserId = 7, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 3, UserId = 8, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 8, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 9, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 6, UserId = 10, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 11, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 9, UserId = 12, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 13, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 10, UserId = 14, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 2, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 2, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 5, UserId = 3, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 7, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 5, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 11, UserId = 6, Review = "Average", Rating = 3.5, IsLike = false });
                
               // Console.WriteLine("Added The Products Review To The List Successfully !!!!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }

        //Method to iterate over the list
        public static void IterateOverList(List<ProductReview> products)
        {
            try
            {
                if (products != null)
                {
                    foreach (ProductReview product in products)
                    {
                        Console.WriteLine(product);
                    }
                }
                else
                    Console.WriteLine("No Products Review Added In The List.....");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //foreach (ProductReview productReview in products)
            //{
            //    Console.WriteLine(productReview);
            //}
        }
        // UC2--Retrieve Top Three Records Whose Rating is High
        public static int RetrieveTopThreeRating(List<ProductReview> products)
        {
            AddProductReviewToList(products);
            Console.WriteLine("\nRetrieving Top Three Records Based On Rating");
            var res = (from product in products orderby product.Rating descending select product).Take(3).ToList();
            IterateOverList(res);
            return res.Count;
        }
        //UC3- retrive records from list whos ratings greater than 3 and id is 1 or 9
        public static List<ProductReview> RetrieveRecordsBasedOnRatingAndProductId(List<ProductReview> products)
        {
            AddProductReviewToList(products);            
            var resProductList = (from product in products where (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) && product.Rating > 3 select product).ToList();
            Console.WriteLine("\nPrinting Records Based On Rating And ProductId");
            IterateOverList(resProductList);
            return resProductList;
        }

        //UC4-Count for each productId
        public static string CountingProductId(List<ProductReview> products)
        {
            string res = null;
            AddProductReviewToList(products);
            var data = products.GroupBy(x => x.ProductId).Select(a => new { ProductId = a.Key, count = a.Count() });
            Console.WriteLine(data);
            foreach (var element in data)
            {
                //Console.WriteLine("ProductId " + element.ProductId + " " + "Count " + " " + element.count);
                res += element.ProductId + " " + element.count + " ";
                Console.WriteLine(res);
            }
            return res;
        }
        //UC5 And UC7-Retrieve Only Product Id And Reviews
        public static string RetrieveOnlyProductIdAndReviews(List<ProductReview> products)
        {
            string result = null;
            AddProductReviewToList(products);
            var res = products.Select(product => new { ProductId = product.ProductId, Review = product.Review }).ToList();
            foreach (var ele in res)
            {
                Console.WriteLine("ProductId " + ele.ProductId + " " + "Review " + " " + ele.Review);
                result += ele.ProductId + " ";
            }
            return result;
        }
        //UC6-Skipping top 5 records And displaying Remaining records
        public static int SkipTopFiveRecords(List<ProductReview> products)
        {
            AddProductReviewToList(products);
            Console.WriteLine("\nSkip Top Five records in list");
            var res = (from product in products orderby product.Rating descending select product).Skip(5).ToList();
            IterateOverList(res);
            return res.Count;
        }
        // UC8-->Using DataTable
        public static void CreateDataTable(List<ProductReview> products)
        {
            AddProductReviewToList(products);
            DataTable dt = new DataTable();
            dt.Columns.Add("productId");
            dt.Columns.Add("userId");
            dt.Columns.Add("rating");
            dt.Columns.Add("review");
            dt.Columns.Add("isLike", typeof(bool));

            foreach (var data in products)
            {
                dt.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
            }
            IterateTable(dt);
            //int c = ReturnsOnlyIsLikeFieldAsTrue(dt);
            //return c;
        }
        /// <summary>
        /// Iterate Thorugh Table
        /// </summary>
        /// <param name="table"></param>
        public static void IterateTable(DataTable table)
        {
            foreach (DataRow p in table.Rows)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
            }
        }
    }
}
