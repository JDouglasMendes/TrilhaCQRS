using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dapper.Test
{
    [TestClass]
    public class SelectTest
    {
        [TestMethod]
        public void FindAllTest()
        {
            var repository = new CategoriesRepository();
            var listCategories = repository.FindAll();
            Assert.IsInstanceOfType(listCategories, typeof(IEnumerable<Categories>));
            Assert.IsTrue(listCategories.Any());
        }

        [TestMethod]
        public void FindByIdTest()
        {
            var repository = new CategoriesRepository();
            var category = repository.FindById(1);
            Assert.IsInstanceOfType(category, typeof(Categories));
            Assert.IsTrue(category.CategoryId > 0);
        }

        [TestMethod]
        public void InnerJoinCategorieProduct()
        {
            var repository = new CategoriesRepository();
            var listCategories = repository.GetCategoriesAndProducts();
            Assert.IsInstanceOfType(listCategories, typeof(IEnumerable<Categories>));
            Assert.IsTrue(listCategories.Any());
        }
    }
}
