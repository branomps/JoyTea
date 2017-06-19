using JoyTea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JoyTea
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new JoyTea.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            List<Product> randomProducts = new List<Product>();
            //if (categoryId.HasValue && categoryId > 0)
            //{
            //    query = query.Where(p => p.CategoryID == categoryId);
            //}
            Random rmd = new Random();
            int count = 1;
            //int rmdItem = rmd.Next(0, 15);
            while(count <= 6)
            {
                int rmdItem = rmd.Next(0, 15);
                foreach (var item  in query)
                {
                    if(item.ProductID == rmdItem)
                    {  
                         randomProducts.Add(item);
                         count++;
                        //if (randomProducts.Find(item.ProductID))
                        //{
                        //    randomProducts.Remove(item);
                        //    count--;
                        //}
                    }

                }
                
            }
            return randomProducts;
        }

    }
}