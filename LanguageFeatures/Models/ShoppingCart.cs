using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class ShoppingCart
    {
        //这个类作用是封闭一个Product对象的列表
        public List<Product> Products { get; set; }

        //public decimal TotalPrices()
        //{//一种是扩展方法MyExtensionMethods，一种是直接添加方法
        //    decimal totalPrice = 0;
        //    foreach (Product prod in Products)
        //    {
        //        totalPrice += prod.Price;
        //    }
        //    return totalPrice;
        //}
    }
}