using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Library
{
    public class Librarian
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LibraryCardNumber { get; set; }
        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Librarian(DataTable dt)
        {
            if (dt.Rows.Count != 1) throw new ArgumentException("Unexpected number of rows");

            DataRow dr = dt.Rows[0];

            ID = dr.Field<int>("PatronID");
            FirstName = dr.Field<string>("FirstName");
            LastName = dr.Field<string>("LastName");
            LibraryCardNumber = dr.Field<string>("LibraryCardNumber");
            BranchID = dr.Field<int>("BranchID");

            

        }
    }
}