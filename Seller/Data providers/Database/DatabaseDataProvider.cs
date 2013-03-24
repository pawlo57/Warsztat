using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pawel.Workshop.Database.Database_model;
using Pawel.Workshop.Entities;

namespace Pawel.Workshop.Data_providers.Databse
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

        #region Categories

        public static List<Categories> getCategories()
        {
            var query = from category in dbContext.Categories
                        select category;

            return query.ToList();
        }

        #endregion

        #region Goods

        public static List<Good> getGoodsByGood()
        {
            var query = from good in dbContext.Programs
                        join category in dbContext.Categories on good.CATID equals category.ID
                        //where (good.CATID > 0 && (programs.CATID == good.CATID))
                        select new Good
                        {
                            ID = good.ID,
                            categoryID = good.CATID == null ? 0 : (int)good.CATID,
                            customerID = good.CID == null ? 0 : (int)good.CID,
                            catalogueNumber = good.NUMERKAT,
                            model = good.MODEL,
                            serialNumber = good.NUMERSER,
                            description = good.OPIS,
                            name = good.NAZWA,
                            vat = good.Vat == null ? 0 : (int)good.Vat,
                            bruttoPriceSell = (decimal)good.VATPRICE,
                            bruttoPriceBuy = (decimal)good.VATPRICE2,
                            unit = good.JEDNOSTKA
                        };

            return query.ToList();
        }

        #endregion

    }
}
