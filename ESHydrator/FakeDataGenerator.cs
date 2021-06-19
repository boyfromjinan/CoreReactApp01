using ElasticSearchService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESHydrator
{
    public static class FakeDataGenerator
    {

        public static IEnumerable<Product> GenerateProducts(int count)
        {
            var faker = new AutoBogus.AutoFaker<Product>();

            var results = faker.Generate(count);

            return results;
        }

    }
}
