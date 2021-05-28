using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Rtl.TvMaze.Scraper
{
    public class ScraperWorker : IHostedService
    {
        private readonly ILogger<ScraperWorker> _logger;

        public ScraperWorker(ILogger<ScraperWorker> logger)
        {
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // Start service.

            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            // TODO: Do some disposing.

            await Task.CompletedTask;
        }
    }
}
