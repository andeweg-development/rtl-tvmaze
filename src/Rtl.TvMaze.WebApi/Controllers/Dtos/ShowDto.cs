using System.Collections.Generic;

namespace Rtl.TvMaze.WebApi.Controllers.Dtos
{
    public class ShowDto
    {
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public string Title { get; set; }
        public List<CastDto> Cast { get; set; }
    }
}
