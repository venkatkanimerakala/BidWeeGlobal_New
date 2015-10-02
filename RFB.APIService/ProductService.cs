using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFB.ServiceInterface;
using RFB.BusinessObjects;

namespace RFB.Service
{
    public class ProductService : IProductService
    {

        //Get Product details based on ProductId like description, image, bidWee Merchant Count, MRP etc
        public Product GetProductDetails(int _productId)
        {
            return null;
        }      

        //Get all products based on the manufacturer & subcategory for ex : Sony & TVs
        public List<Product>  GetAllProduct(int _manufacturerId, int _subCategoryId)
        {
            return null;
        }

        // Get all list of manufacturers based on SubCategory
        public List<Manufacturer> GetAllManufacterers(int _subCategoryId)
        {
            return null;
        }

        // Get all list of SubCategories based on Category
        public List<Category> GetAllCategories()
        {
            return null;
        }

        // Get all list of Categories
        public List<SubCategory> GetAllSubCategories(int _categoryId)
        {
            return null;
        }

        //Return list of Products based on search key
        public List<Product> GetProductsByKeyWord(string _searchKey)
        {
            return null;
        }
        
    }
}
