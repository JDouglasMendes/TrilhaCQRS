using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
    public class CategoriesRepository
    {
        public IEnumerable<Categories> FindAll()
        {
            using (var conexao = new Connection().CrieConexao())
            {
                return conexao.Query<Categories>("SELECT * FROM Categories");
            }       
        }

        public Categories FindById(int codigo)
        {
            using (var conexao = new Connection().CrieConexao())
            {
                return conexao.Query<Categories>("SELECT * FROM Categories WHERE CategoryID = @CategoryID", new Categories() {CategoryId = codigo}).FirstOrDefault();
            }
        }

        public IEnumerable<Categories> GetCategoriesAndProducts()
        {
            using (var conexao = new Connection().CrieConexao())
            {
                var dictionaryHelper = new Dictionary<int, Categories>();
                conexao.Query<Categories, Products, Categories>(string.Concat("SELECT c.*, p.*",
                    " FROM Categories c",
                    " INNER JOIN Products p ON c.CategoryID = p.CategoryID ")
                    , (c, p) =>
                    {
                        Categories categories;
                        if (!dictionaryHelper.TryGetValue(c.CategoryId, out categories))
                        {
                            dictionaryHelper.Add(c.CategoryId, categories = c);
                        }
                        if (categories != null && categories.Productses == null)
                            categories.Productses = new List<Products>();

                        categories?.Productses.Add(p);
                        return categories;
                    }, splitOn: "CategoryID,ProductID");

                return dictionaryHelper.Values;
            }
        }
    }
}
