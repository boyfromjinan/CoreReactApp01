using System;
using System.Collections.Generic;
using ElasticSearchService;
using ElasticSearchService.Model;

namespace ElasticSearchService
{
    public class ElasticSearchService : IElasticSearchService
    {
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> SearchProducts(ProductSearchCriterion productSearchCriterion)
        {
            throw new NotImplementedException();
        }
    }
}
