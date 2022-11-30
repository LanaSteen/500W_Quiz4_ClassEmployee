using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500W_Quiz4_ClassEmployee
{
    public class Department 
    {
        //Შექმენით კლასი დეპარტამენტი რომელსაც ექნება დეპარტამენტის დასახელება და მაქსიმალური თანამშრომელის რაოდენობა(ველები).
        public int depId;
        public string depName;
        public int maxEmp;
        public List<Employee> d_emp = new List<Employee>();
        public List<Employee> EmpList
        {
            get { return d_emp; }
        }

        public Department(string depName, int maxEmp)
        {
            this.depName = depName;
            this.maxEmp = maxEmp;  
        }
        public void AddEmployee(Employee employee)
        {
            if (d_emp.Count() < maxEmp)
                d_emp.Add(employee);
        }

        public void DeleteEmployee(int empId)
        {
            d_emp.RemoveAll(a => a.empId == empId);
        }



        public static void PrintDepsInfo(List<Department> departments)
        {
            foreach (var dep in departments)
            {
                Console.WriteLine(" Employees in " + dep.depName + " department");
                foreach (var dE in dep.EmpList)
                {
                    Console.WriteLine("-----> ID: " + dE.empId +
                               ", Name: " + dE.fname +
                               ", Lastname: " + dE.lname +
                               ", Identification N:  " + dE.identifNum +
                               ", Salary: " + dE.salarry);
                }
            }
        }
        public static void PrintDeps(List<Department> departments)
        {
            foreach (var dep in departments)
            {
                Console.WriteLine(dep.depName + " department" + " Maximum number of Employees - " + dep.maxEmp);
                
            }
        }



        public static void PrintCountEmps(Department department)
        {
           
                Console.WriteLine(department.depName +" Department has: " + department.EmpList.Count() + " employees");

        }
    }
}
