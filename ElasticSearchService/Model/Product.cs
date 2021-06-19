namespace ElasticSearchService.Model
{
    public class Product : ModelBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public bool Active { get; set; }

    }
}