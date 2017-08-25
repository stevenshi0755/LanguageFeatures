using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace LanguageFeatures.Models
{
    public class ShoppingCart:IEnumerable<Product>
    {
        //这个类作用是封闭一个Product对象的列表
        public List<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            //对接口进行扩展
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //对接口进行扩展
            return GetEnumerator();
        }
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