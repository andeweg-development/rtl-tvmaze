using System.Collections.Generic;
using Rtl.TvMaze.Implementation.Models;

namespace Rtl.TvMaze.Implementation.Services.Interfaces
{
    public interface IShowService
    {
        IEnumerable<Show> GetAllShows();
    }
}
