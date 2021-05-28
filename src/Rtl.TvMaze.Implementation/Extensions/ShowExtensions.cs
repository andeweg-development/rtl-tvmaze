using System.Collections.Generic;
using Rtl.TvMaze.DataAccess.Entities;
using Rtl.TvMaze.Implementation.Models;

namespace Rtl.TvMaze.Implementation.Extensions
{
    public static class ShowExtensions
    {
        public static IEnumerable<Show> ToModel(this IEnumerable<ShowEntity> entities)
        {
            foreach (var entity in entities)
            {
                yield return entity.ToModel();
            }
        }

        public static Show ToModel(this ShowEntity entity)
        {
            return new Show()
            {

            };
        }
    }
}
