using Library.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Library
{
    public class Repository
    {
        public static DataTable GetLibrarian(string librarycardnumber)
        {
            return DatabaseHelper.Retrieve(@"
            select p.PatronID, p.FirstName, p.LastName p.LibraryCardNumber,
            br.BranchID, br.Name as BranchName, l.EmployeeNumber, l.HashedPassword
            from Patron p
            join librarian l on l.PatronID = p.PatronID
            join Branch br on br.BranchID = l.BranchID
            where p.LibraryardNumber = @LibraryCardNumber
            ",

            new SqlParameter("@LibraryCardNumber", librarycardnumber));

        }
    }
}