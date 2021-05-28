using System.Collections.Generic;
using Rtl.TvMaze.DataAccess.Entities;
using Rtl.TvMaze.DataAccess.Repositories.Interfaces;

namespace Rtl.TvMaze.DataAccess.Repositories
{
    public class ShowRepository : IShowRepository
    {
        public IEnumerable<ShowEntity> GetAllShows()
        {
            return new List<ShowEntity>();
        }
    }
}
