using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart cartParam)
        //第一个参数前this把TotalPrices标记为一个扩展方法，告诉.NET这个扩展方法用于哪个类
        //此处为ShoppingCart类，可以通过cartParam参数来引用ShoppingCart类的实例
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)  
            //该扩展方法枚举了ShoppingCart中的所有Product，并返回Product.Price属性之和
            {
                total += prod.Price;
            }
            return total;
        }
    }
}