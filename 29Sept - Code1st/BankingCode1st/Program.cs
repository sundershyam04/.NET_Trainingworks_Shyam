using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingDB;

namespace BankingCode1st
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banking  context = new Banking();

            //create borrower and loan

            Borrower b = new Borrower();

            b.BorrowerId = 2312;
            b.Name = "Siva";
            b.City = "bangalore";
            b.State = "TamilNadu";
            b.Country = "India";
            b.StreetName = "anna street";
            b.CompanyName = "dell";
            b.JobName = "Cloud Architect";

     
            Loan l = new Loan();

            l.LoanId = 7;
            l.LoanType = "Personal";
            l.LoanAmount = 2507000.75f;
            l.Durationmonths = 36;
            l.InterestRate = 4.5f;

            context.Loans.Add(l);

            Loan l1 = new Loan();

            l1.LoanId = 8;
            l1.LoanType = "Housing";
            l1.LoanAmount = 1000070.75f;
            l1.Durationmonths = 24;
            l1.InterestRate = 3.5f;

            context.Loans.Add(l1);


            List<Loan> llist = new List<Loan>();
            llist.Add(l);
            llist.Add(l1);

            b.loanlist = llist;

          

            context.Borrowers.Add(b);

           

            context.SaveChanges();

            Console.WriteLine(  "Successfull...");

            Console.Read();

        }

    }
}
