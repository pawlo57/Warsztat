using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pawel.Workshop.Update.Database;

namespace Pawel.Workshop.Update.Data_providers.Update_database
{
    public static class UpdateDatabaseDataProvider
    {
        public static void updateGoods()
        {
            renameTable("Programs", "Goods");
            renameColumnInTable("MODEL","Model","Goods");
        }

        private static void renameTable(string oldName, string newName)
        {
            string query = string.Format("sp_rename '{0}','{1}'", oldName, newName);

            Connect.SetCommand(query);
        }

        private static void renameColumnInTable(string oldColumnName, string newColumnName, string tableName)
        {
            string query = string.Format("ALTER TABLE [{0}] ADD [{1}] NVARCHAR(50)",tableName,newColumnName);
            Connect.SetCommand(query);
            
            query = string.Format("UPDATE {0} set {1} = {2}",tableName,newColumnName,oldColumnName);
            Connect.SetCommand(query);

            query = string.Format("ALTER Table [{0}] drop column [{1}]", tableName, oldColumnName);
            Connect.SetIDCommand(query);
        }
    }
}
