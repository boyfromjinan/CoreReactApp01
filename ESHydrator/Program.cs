using System;
using Newtonsoft.Json;

namespace ESHydrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = FakeDataGenerator.GenerateProducts(10);

            //foreach (var product in products)
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(product));
            //}

            Console.ReadKey();
        }
    }
}
