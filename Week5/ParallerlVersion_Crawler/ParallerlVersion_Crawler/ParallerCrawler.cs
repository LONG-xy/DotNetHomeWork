using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelVersion_Crawler
{
    class ParallelCrawler
    {
        public event Action<ParallelCrawler> CrawlerStopped;
        public event Action<ParallelCrawler, int, string, string> PageDownloaded;

        private readonly ConcurrentDictionary<string, bool> _urls = new ConcurrentDictionary<string, bool>();

        private ConcurrentQueue<string> _waitingQueue = new ConcurrentQueue<string>();

        private readonly string urlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";

        public static readonly string _urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
        public string HostFilter { get; set; } 
        public string FileFilter { get; set; } 
        public int MaxPage { get; set; } 
        public string StartUrl { get; set; }
        public Encoding HtmlEncoding { get; set; } 

        public ParallelCrawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Start()
        {
            _urls.Clear();
            _waitingQueue = new ConcurrentQueue<string>();
            _waitingQueue.Enqueue(StartUrl);

            List<Task> tasks = new List<Task>();
            int complatedCount = 0;
            PageDownloaded += (crawler, index, url, info) => { complatedCount++; };

            while (tasks.Count < MaxPage)
            {
                if (!_waitingQueue.TryDequeue(out string url))
                {
                    if (complatedCount < tasks.Count)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                int index = tasks.Count;
                Task task = Task.Run(() => DownloadAndParse(url, index));
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
            CrawlerStopped(this);
         }

        private void DownloadAndParse(string url, int index)
        {
            try
            {
                string html = DownLoad(url, index);
                _urls[url] = true;
                Parse(html, url);
                PageDownloaded(this, index, url, "success");
            }
            catch (Exception ex)
            {
                PageDownloaded(this, index, url, "Error:" + ex.Message);
            }
        }

        private string DownLoad(string url, int index)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = HtmlEncoding;
            string html = webClient.DownloadString(url);
            File.WriteAllText(index + ".html", html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(urlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);

                Match linkUrlMatch = Regex.Match(linkUrl, _urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !_urls.ContainsKey(linkUrl))
                {
                    _waitingQueue.Enqueue(linkUrl);
                    _urls.TryAdd(linkUrl, false);
                }
            }
        }


        static private string FixUrl(string url, string baseUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(baseUrl, _urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = baseUrl.LastIndexOf('/');
                return FixUrl(url, baseUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), baseUrl);
            }

            int end = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, end) + "/" + url;
        }
    }


}

