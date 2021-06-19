using ElasticSearchService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchService
{
    interface IElasticSearchService
    {
        IEnumerable<Product> SearchProducts(ProductSearchCriterion productSearchCriterion);
        IEnumerable<Product> GetAllProducts();
        
    }
}
