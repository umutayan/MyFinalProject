using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            ProductTest();
            //IoC
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoyManager categoyManager = new CategoyManager(new EfCategoryDal());
            foreach (var category in categoyManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result= productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}