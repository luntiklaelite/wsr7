using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wsr7.Migrations
{
    class SqlGenerator : MySqlMigrationSqlGenerator
    {
        protected override MigrationStatement Generate(CreateIndexOperation op)
        {
            CultureInfo current = Thread.CurrentThread.CurrentCulture;
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
                return base.Generate(op);
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = current;
            }
        }
    }
}
