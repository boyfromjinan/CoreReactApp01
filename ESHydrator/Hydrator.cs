using Elasticsearch.Net;
using ElasticSearchService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESHydrator
{
    internal static class Hydrator
    {
        static void HydrateProducts(IEnumerable<Product> products)
        {
            var config = new ConnectionConfiguration().ApiKeyAuthentication(new ApiKeyAuthenticationCredentials())

        }

    }
}
