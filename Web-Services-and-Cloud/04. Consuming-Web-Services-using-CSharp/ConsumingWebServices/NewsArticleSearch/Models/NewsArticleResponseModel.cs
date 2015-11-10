namespace NewsArticleSearch
{
    using System.Collections.Generic;

    public class NewsArticleResponseModel
    {
        public Metadata Metadata { get; set; }

        public List<Result> Results { get; set; }
    }
}