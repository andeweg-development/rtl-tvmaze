using System.Collections.Generic;
using Rtl.TvMaze.Implementation.Models;
using Rtl.TvMaze.WebApi.Controllers.Dtos;

namespace Rtl.TvMaze.WebApi.Extensions
{
    public static class ShowDtoExtensions
    {
        public static IEnumerable<ShowDto> ToDto(this IEnumerable<Show> entities)
        {
            foreach (var entity in entities)
            {
                yield return entity.ToDto();
            }
        }

        public static ShowDto ToDto(this Show entity)
        {
            return new ShowDto()
            {

            };
        }
    }
}
