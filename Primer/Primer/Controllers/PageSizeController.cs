using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using Primer.Infrastructure;
using System.Threading;

namespace Primer.Controllers
{
    public class PageSizeController : ApiController, ICustomController
    {
        private static string TargetUrl = "http://apress.com";

        public async Task<long> GetPageSize(CancellationToken cToken)
        {
            
                WebClient wc = new WebClient();
                Stopwatch sw = Stopwatch.StartNew();
            byte[] apressData = await wc.DownloadDataTaskAsync(TargetUrl);
                            Debug.WriteLine("Elapsed ms: {0}", sw.ElapsedMilliseconds);
            return apressData.LongLength;
        }

        public Task PostUrl(string newUrl, CancellationToken cToken)
        {
            TargetUrl = newUrl;
            return Task.FromResult<Object>(null);
        }
    }
}
