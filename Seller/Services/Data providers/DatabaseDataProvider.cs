using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seller.Database.Database_model;

namespace Seller.Services.Data_providers
{
    public class DatabaseDataProvider
    {
        private static DatabaseEntities dbContext = new DatabaseEntities();

        public static void checkLinq()
        {
            var query = from car in dbContext.Cars
                        select car;

            int count = query.ToList();
        }
        
    }
}
