using InvoiceMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Data
{
    public class ClientRepository
    {
        private Context context;

        public ClientRepository(Context context)
        {
            if(context == null)
            {
                throw new ArgumentException(string.Empty);
            }
            this.context = context;
        }

        public List<Client> GetList()
        {
            return null;
        }
    }
}