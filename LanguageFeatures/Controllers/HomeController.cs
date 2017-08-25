using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;
using LanguageFeatures;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL to show an example";
            //return View();
        }
        public ViewResult AutoProperty()
        {
            //创建一个新的Product对象
            Product myProduct = new Product();
            //设置属性值
            myProduct.Name = "Kayak";
            //读取属性
            string productName = myProduct.Name;
            //生成视图
            return View("Result", (object)String.Format("Product name:{0}", productName));
        }
        public string Action1()
        {
            Product myAction = new Product();
            myAction.Description = "the description";
            return (myAction.Description);
        }
        public ViewResult CreateProduct()
        {
            //Product myProduct = new Product();
            //myProduct.ProductID = 100;
            //myProduct.Name = "Stevenshi";
            //myProduct.Description = "A boat for one person";
            //myProduct.Price = 275M;
            //myProduct.Category = "Watersports";

            //对象初始化器
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Steven Shi",
                Description = "A boat for one person",
                Price = 275m,
                Category = "Watersports"
            };
            //return View( (object)myProduct.Category);
            return View("Result", (object)String.Format("Category:{0}", myProduct.Category));
        }
        public ViewResult CreateCollection()
        {
            //string[] stringArray = { "apple", "orange", "plum" };
            string[] stringArray = new string[] { "apple", "orange", "plum" };
            List<int> intList = new List<int> { 10, 20, 30, 40 };
            Dictionary<string, int> myDict = new Dictionary<string, int> { { "apple", 10 }, { "orange", 20 }, { "plum", 30 } };
            return View("Result", (object)stringArray[1]);
        }
        //public ViewResult UserExtension()
        ////创建并填充ShoppingCart
        //{
        //    ShoppingCart cart = new ShoppingCart
        //    {
        //        Products = new List<Product>
        //        {
        //            new Product{Name="Kayak",Price=275M},
        //            new Product{Name="Lifejacket",Price=48.95M},
        //            new Product{Name="soccer ball",Price=19.50M},
        //            new Product{Name="Corner flag",Price=34.95M}
        //        }
        //    };
        //    //求购物车中产品总价
        //    decimal cartTotal = cart.TotalPrices();
        //    return View("Result",(object)string.Format("Total price is:{0:c}",cartTotal));
        //}

        public ViewResult UseExtensionEnumerable()
        //创建并填充ShoppingCart
        {
            IEnumerable<Product> Products = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product{Name="Kayak",Price=275M},
                    new Product{Name="Lifejacket",Price=48.95M},
                    new Product{Name="soccer ball",Price=19.50M},
                    new Product{Name="Corner flag",Price=34.95M}
                }
            };
            //创建并填充一个Product对象的数组
            Product[] productArray =
            {
                new Product {Name="Kayak",Price=275M},
                new Product {Name="Lifejacket",Price=48.95M},
                new Product {Name="Soccer ball",Price=19.50M},
                new Product {Name="Corner flag",Price=34.95M}
            };
            //获取购物车中产品的总价
            decimal cartTotal = Products.TotalPrices();
            decimal arrayTotal = Products.TotalPrices();
            return View("Result", (object)String.Format("Cart Total:{0},Array Total:{1}", cartTotal, arrayTotal));

            //求购物车中产品总价
            //decimal cartTotal = cart.TotalPrices();
            //return View("Result", (object)string.Format("Total price is:{0:c}", cartTotal));

        }
    }
}