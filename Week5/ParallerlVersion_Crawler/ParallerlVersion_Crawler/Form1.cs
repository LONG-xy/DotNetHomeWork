using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelVersion_Crawler

{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        ParallelCrawler ParallelCrawler = new ParallelCrawler();
        Thread thread = null;

        public Form1()
        {
            InitializeComponent();
            dgvCrawlResult.DataSource = resultBindingSource;
            ParallelCrawler.PageDownloaded += ParallelCrawler_PageDownloaded;
            ParallelCrawler.CrawlerStopped += ParallelCrawler_ParallelCrawlerStopped;
        }

        private void ParallelCrawler_ParallelCrawlerStopped(ParallelCrawler obj)
        {
            Action action = () => StatusInfo.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void ParallelCrawler_PageDownloaded(ParallelCrawler ParallelCrawler, int index, string url, string info)
        {
            var pageInfo = new { Index = index, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            ParallelCrawler.StartUrl = txtUrl.Text;

            Match match = Regex.Match(ParallelCrawler.StartUrl, ParallelCrawler._urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            ParallelCrawler.HostFilter = "^" + host + "$";
            ParallelCrawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(ParallelCrawler.Start);
            thread.Start();
            StatusInfo.Text = "爬虫已启动....";

        }

    }
}


