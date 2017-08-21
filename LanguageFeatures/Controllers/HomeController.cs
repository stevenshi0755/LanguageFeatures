using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

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
    }
}