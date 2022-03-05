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
            //Creating object of product review
            //List<ProductReview> products = new List<ProductReview>();
            try
            {
               Console.WriteLine("1: Add Product Review To List \n2: Show All Product Review \n3: Exit");
               Console.Write("Choose the option from above : ");
               int option=Convert.ToInt32(Console.ReadLine());
               bool flag = true;
               switch (option)
               {
                 case 1:
                       //Calling the method of adding product review to list(UC1)
                       //products=ProductReviewManager.AddProductReviewToList();
                       listOfProduct = ProductReviewManager.AddProductReviewToList();
                        //Console.WriteLine(listOfProduct);
                       break;
                  case 2:
                        //Calling the method to show the product review list(UC1)
                        listOfProduct = ProductReviewManager.AddProductReviewToList();
                        ProductReviewManager.IterateOverList(listOfProduct);
                          break;
                   case 3:
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
