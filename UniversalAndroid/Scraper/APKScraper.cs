using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace UniversalAndroid
{
    class APKScraper
    {
        private List<System.Net.WebClient> download_clients = new List<System.Net.WebClient>();
        private Dictionary<Program.scrapingModels, string> scraper_bases = new Dictionary<Program.scrapingModels, string>()
        {
            { Program.scrapingModels.REXDL, "https://rexdl.com/?s={0}" }
        };

        public List<ScraperData> fetchDownloadData(string search)
        {

            var scraperdata_sources = new List<string>();
            var scraped_collection = new List<ScraperData>();

            foreach (var scraper_source in Enum.GetValues(typeof(Program.scrapingModels)).Cast<Program.scrapingModels>())
            {
                foreach (var search_method in Enum.GetValues(typeof(Program.searchMethods)).Cast<Program.searchMethods>())
                {
                    scraperdata_sources = scraperdata_sources.Concat(GetDataUrl(scraper_source, search, search_method)).ToList();
                }

            }


            foreach (var scraper_source in Enum.GetValues(typeof(Program.scrapingModels)).Cast<Program.scrapingModels>())
            {
                foreach (var scraperdata_source in scraperdata_sources)
                    if (!string.IsNullOrEmpty(scraperdata_source))
                    {
                        var dl_data = parseScraperData(scraper_source, scraperdata_source);
                        scraped_collection.Add(dl_data);
                    }
            }

            return scraped_collection;
        }


        public List<string> GetDataUrl(Program.scrapingModels model, string search, Program.searchMethods search_method)
        {
            var additional_keywords = new[] { "apk" };
            string url;
            if (!scraper_bases.TryGetValue(model, out url) | string.IsNullOrEmpty(search)) throw new ArgumentException();
            HtmlWeb loader = new HtmlWeb();
            var doc = loader.Load(String.Format(url, search.Replace(" ", "+")));
            var page_urls = sanatizeUrlSet(doc.DocumentNode.SelectNodes("//a[@href]"));

            switch (search_method)
            {
                default:
                case Program.searchMethods.KEYWORD:
                    // Check for each url that contains all search words & the additional required keywords, 
                    // -  afterwards count values that are true, and check or the value matches the count of the searchwords + additionals
                    var keywordSearch = page_urls.Where(b => (search.Split().Concat(additional_keywords).Select(s => b.Contains(s))).Count(c => c) == search.Split().Count() + additional_keywords.Count());

                    List<string> data_urls = new List<string>();
                    foreach (var result in keywordSearch)
                    {
                        // For rexdl skip info page
   
                        var dlbase = result.Split('/')[result.Split('/').Count() - 2];
                        data_urls.Add(String.Format("https://rexdlfile.com/index.php?id={0}", dlbase.Remove(dlbase.IndexOf('.'))));
                    }
                    return data_urls.Distinct().ToList();
            }

        }

        public ScraperData parseScraperData(Program.scrapingModels model, string page_uri)
        {
            var data = new ScraperData();

            switch (model)
            {
                case Program.scrapingModels.REXDL:
                    HtmlWeb loader = new HtmlWeb();
                    var page_urls = this.sanatizeUrlSet(loader.Load(page_uri).DocumentNode.SelectNodes("//a[@href]")).Where(i => i.ToLower().EndsWith(".apk") | i.ToLower().EndsWith(".zip"));


                    // Parse urls.
                    data.apk_link = page_urls.Where(i => i.EndsWith(".apk")).FirstOrDefault();
                    data.obb_link = page_urls.Where(i => i.EndsWith(".zip")).FirstOrDefault();

                    break;
            }

            return data;
        }



        public IEnumerable<string> sanatizeUrlSet(HtmlNodeCollection node_set)
        {
            return node_set.Select(n => n.OuterHtml.Split('>').First().Split().Where(i => i.Contains("href")).FirstOrDefault())
                .Where(i => i.Length > 0 & i.Contains('"'))
                .Select(i => (i.Substring(i.IndexOf('"') + 1)).Replace("\"", ""));
        }

    }
}
