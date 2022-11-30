using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500W_Quiz4_ClassEmployee
{
    public class Employee 
    {
        //Შექმენით კლასი Employee რომელსაც ექნება სახელი, გვარი, პირადი ნომერი და ხელფასის ველები.
        public int empId;
        public string fname;
        public string lname;
        public string identifNum;
        public decimal salarry;



        public Employee(int empId, string fname, string lname, string identifNum, decimal salarry)
        {
            this.empId = empId;
            this.fname = fname;
            this.lname = lname;
            this.identifNum = identifNum;
            try
            {
                this.salarry = Convert.ToDecimal(salarry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Wrong number in salarry");
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Employee name:{fname}");
        }

        public string GetFullName()   
        {
            return fname + " " + lname;
        }

       


    }
}
