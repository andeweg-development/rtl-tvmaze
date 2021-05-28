using System;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Rtl.TvMaze.Infrastructure.Apis;
using Rtl.TvMaze.Infrastructure.Services;
using Rtl.TvMaze.Infrastructure.Services.Interfaces;

namespace Rtl.TvMaze.Infrastructure
{
    public static class DependencyConfiguration
    {
        public static IServiceCollection ConfigureInfrastructure(this IServiceCollection serviceCollection)
        {
            // TODO: Read from config
            var tvMazeBaseUrl = "http://api.tvmaze.com";

            serviceCollection
                .AddRefitClient<ITvMazeApi>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(tvMazeBaseUrl));


            serviceCollection.AddTransient<ITvMazeService, TvMazeService>();

            return serviceCollection;
        }
    }
}
