namespace NewsArticleSearch
{
    using System;
    using System.Net;

    using Newtonsoft.Json;

    public class Startup
    {
        public static void Main()
        {
            // Unfortunately, the API from the task description is unavaiable, so I used this one, but it can't filter news by query string. So, count only!
            Console.WriteLine("Enter count of articles to fetch: ");
            string pageSize = Console.ReadLine();

            var client = new WebClient();
            client.Headers.Add("User-Agent: .NET"); // workaround for 403 (they check the user agent)

            string newsArticles = client.DownloadString("http://justice.gov/api/v1/press_releases.json?pagesize=" + pageSize);
            NewsArticleResponseModel result = JsonConvert.DeserializeObject<NewsArticleResponseModel>(newsArticles);

            foreach (var entry in result.Results)
            {
                Console.WriteLine(string.Format("Title: {0}\nURL: {1}\n", entry.Title, entry.Url));
            }
        }
    }
}
