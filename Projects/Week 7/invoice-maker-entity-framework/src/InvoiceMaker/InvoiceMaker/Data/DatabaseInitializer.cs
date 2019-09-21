using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Data
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<Context>
    {
        public override void InitializeDatabase(Context context)
        {
            
        }
    }
}