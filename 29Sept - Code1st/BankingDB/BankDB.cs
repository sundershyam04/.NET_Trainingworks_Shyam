using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingDB
{

    public class Loan
    {
        [Key, Required]
        public int LoanId { get; set; }
        public string LoanType { get; set; }

        public Single LoanAmount { get; set; }

        public int Durationmonths { get; set; }

        public Single InterestRate { get; set; }

        public virtual List<Borrower> borrlist { get; set; }

    }
    public class Borrower
    {
        [Key]
        [Required]
        public int BorrowerId { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
        [DataType(DataType.Text, ErrorMessage = "Street name Should be a text")]
        public string StreetName { get; set; }
      
        public string CompanyName { get; set; }

        public string JobName { get; set; }

        [ForeignKey("LoanId")]
        public virtual List<Loan> loanlist {  get; set; }


    }

    


    public class Banking : DbContext
    {
        public Banking(): base("Banking")
        {
            Database.SetInitializer<Banking>(new CreateDatabaseIfNotExists<Banking>());
        }

        public virtual DbSet<Borrower> Borrowers { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
    }

}
