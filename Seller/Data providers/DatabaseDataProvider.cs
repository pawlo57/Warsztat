using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pawel.Workshop.Database.Database_model;

namespace Pawel.Workshop.Data_providers
{
    public static class DatabaseDataProvider
    {
        private static DatabaseEntities dbContext = new DatabaseEntities();

        public static void checkLinq()
        {
            var query = from car in dbContext.Cars
                        select car;

            IEnumerable<Cars> count = query.ToList();
        }

        #region Goods

        public static IEnumerable<Programs> getGoodsByGood(Programs good)
        {
            var query = from programs in dbContext.Programs
                        where (good.CATID > 0 && (programs.CATID == good.CATID))
                        //where good.NUMERKAT == programs.NUMERKAT
                        select programs;

            return query;
        }

        #endregion

    }
}
