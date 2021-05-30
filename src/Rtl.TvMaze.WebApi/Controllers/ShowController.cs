using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rtl.TvMaze.Implementation.Services.Interfaces;
using Rtl.TvMaze.WebApi.Controllers.Dtos;
using Rtl.TvMaze.WebApi.Extensions;

namespace Rtl.TvMaze.WebApi.Controllers
{
    [ApiController]
    [Route("show")]
    [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
    public class ShowController : ControllerBase
    {
        private readonly IShowService _showService;
        private readonly ILogger<ShowController> _logger;

        public ShowController(
            IShowService showService,
            ILogger<ShowController> logger)
        {
            _showService = showService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ShowDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<ShowDto>> Get()
        {
            var shows = (await _showService
                .GetAllShows())
                .ToDto();

            return shows;
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ShowDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public ShowDto GetById(int id)
        {
            return null;
        }
    }
}
