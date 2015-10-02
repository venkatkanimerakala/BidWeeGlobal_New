using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.BusinessObjects;

namespace RFB.ServiceInterface
{
   public interface IProductService
    {
      Product GetProductDetails(int productId);
      List<Product> GetProductsByKeyWord(string _searchKey);
      List<Product> GetAllProduct(int _manufacturerId, int _subCategoryId);
      List<Manufacturer> GetAllManufacterers(int _subCategoryId);
      List<SubCategory> GetAllSubCategories(int _categoryId);
      List<Category> GetAllCategories();
    }
}
