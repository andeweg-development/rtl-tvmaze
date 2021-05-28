using Microsoft.Extensions.DependencyInjection;
using Rtl.TvMaze.DataAccess.Repositories;
using Rtl.TvMaze.DataAccess.Repositories.Interfaces;

namespace Rtl.TvMaze.DataAccess
{
    public static class DependencyConfiguration
    {
        public static IServiceCollection ConfigureDataAccess(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IShowRepository, ShowRepository>();

            return serviceCollection;
        }
    }
}
