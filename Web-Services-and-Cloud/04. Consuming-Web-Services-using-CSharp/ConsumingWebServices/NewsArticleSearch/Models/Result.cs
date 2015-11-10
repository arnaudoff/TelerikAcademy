namespace NewsArticleSearch
{
    using System.Collections.Generic;

    public class Result
    {
        public List<object> Attachment { get; set; }

        public string Body { get; set; }

        public string Changed { get; set; }

        public List<Component> Component { get; set; }

        public string Created { get; set; }

        public string Date { get; set; }

        public List<object> Image { get; set; }

        public object Number { get; set; }

        public object SecondaryTeaser { get; set; }

        public object Teaser { get; set; }

        public string Title { get; set; }

        public List<object> Topic { get; set; }

        public string Url { get; set; }

        public string Uuid { get; set; }

        public string Vuuid { get; set; }
    }
}