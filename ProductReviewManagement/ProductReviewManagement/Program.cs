using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        //Declaring variable
        public static List<ProductReview> listOfProduct;
        static void Main(string[] args)
        {
            Console.WriteLine("WEL-COME to product review management program");
            try
            {
               Console.WriteLine("1: Add Product Review To List \n2: Show All Product Review \n3:Retrieve top 3 records rating is high\n4:Retrieve records based on productId and ratings greater than 3" +
                   "\n 5.Count ProductId\n6.Retrieve only ProductId And Review\n7: Exit");
               Console.Write("Choose the option from above : ");
               int option=Convert.ToInt32(Console.ReadLine());
                List<ProductReview> products = new List<ProductReview>();
               bool flag = true;
               switch (option)
               {
                 case 1:
                       //Calling the method of adding product review to list(UC1)                      
                       listOfProduct = ProductReviewManager.AddProductReviewToList(products);
                        //Console.WriteLine(listOfProduct);
                       break;
                  case 2:
                        //Calling the method to show the product review list(UC1)
                        listOfProduct = ProductReviewManager.AddProductReviewToList(products);
                        ProductReviewManager.IterateOverList(listOfProduct);
                          break;
                    case 3:
                        //Calling method to retrieve top three records
                        ProductReviewManager.RetrieveTopThreeRating(products);
                        break ;
                   case 4:
                        //Calling method to retrieve all record whos rating greater than3 and id is 1 or 4
                        ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(products);
                        break;
                    case 5:
                        //Calling method to count each productId present in the list
                        ProductReviewManager.CountingProductId(products);
                        break;
                    case 6:
                        //
                        ProductReviewManager.RetrieveOnlyProductIdAndReviews(products);
                        break;
                   case 7:
                         flag = false;
                          break;
                   default:
                                Console.WriteLine("Wrong choice choose again");
                        break;
               }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }


    }
}
