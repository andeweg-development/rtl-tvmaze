using System.Collections.Generic;
using Rtl.TvMaze.DataAccess.Entities;
using Rtl.TvMaze.Implementation.Models;

namespace Rtl.TvMaze.Implementation.Extensions
{
    public static class CastExtensions
    {
        public static IEnumerable<Cast> ToModel(this IEnumerable<CastEntity> entities)
        {
            foreach (var entity in entities)
            {
                yield return entity.ToModel();
            }
        }

        public static Cast ToModel(this CastEntity entity)
        {
            return new Cast()
            {

            };
        }
    }
}
