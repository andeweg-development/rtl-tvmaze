using System.Collections.Generic;
using Rtl.TvMaze.DataAccess.Repositories.Interfaces;
using Rtl.TvMaze.Implementation.Extensions;
using Rtl.TvMaze.Implementation.Models;
using Rtl.TvMaze.Implementation.Services.Interfaces;
using Rtl.TvMaze.Infrastructure.Services.Interfaces;

namespace Rtl.TvMaze.Implementation.Services
{
    public class ShowService : IShowService
    {
        private readonly ITvMazeService _tvMazeService;
        private readonly IShowRepository _showRepository;

        public ShowService(
            ITvMazeService tvMazeService,
            IShowRepository showRepository)
        {
            _tvMazeService = tvMazeService;
            _showRepository = showRepository;
        }

        public void SyncAllShowsFromTvMaze()
        {
            // fetch all shows
            var allShows = _tvMazeService.GetAllTvShows();

            // sync shows with database

        }

        public IEnumerable<Show> GetAllShows()
        {
            var shows = _showRepository.GetAllShows();

            return shows.ToModel();
        }
    }
}
