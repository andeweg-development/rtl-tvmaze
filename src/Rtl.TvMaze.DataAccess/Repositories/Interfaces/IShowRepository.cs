using System.Collections.Generic;
using Rtl.TvMaze.DataAccess.Entities;

namespace Rtl.TvMaze.DataAccess.Repositories.Interfaces
{
    public interface IShowRepository
    {
        IEnumerable<ShowEntity> GetAllShows();
    }
}
