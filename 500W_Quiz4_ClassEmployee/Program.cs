using System;
using System.Collections.Generic;


namespace _500W_Quiz4_ClassEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Შექმენით კლასი Employee რომელსაც ექნება სახელი, გვარი, პირადი ნომერი და ხელფასის ველები.
           Შექმენით კლასი დეპარტამენტი რომელსაც ექნება დეპარტამენტის დასახელება და მაქსიმალური თანამშრომელის რაოდენობა(ველები).
            Employee კლასში დაამატეთ დეპარტამენტი ისე რომ შეიძებოდეს ამ დეპარტამენტებში თანამშრომლების დამატება, 
            იმ შემთხვევაში თუ მაქსიმალურ რაოდენობას გადააჭარბა თანამშრომელი ვერ უნდა დაემატოს. 
            
            Შექმენით მეთოდები რომელიც:
            Დაამატებს თანამშრომელს დეპარტამენტში
            Წაშლის თანამშრომელს დეპარტამენტში
            Დაბეჭდავს დეპარტამენტების სიას
            Დაბეჭდავს თანამშრომლების სიას დეპარტამენტების მიხედვით
            Დაითვლის თანამშრომლების რაოდენობას თითოეულ დეპარტამენტში(ცალკე ველი არ უნდა გქონდეს დეპარტამენტის კლასში ამისთვის)*/


            List<Employee> employees1 = new List<Employee>();
            employees1.Add(new Employee(1, "Jane", "Smith", "11111111", 5000));
            employees1.Add(new Employee(2, "John", "Smith", "22222222", 5000));
            employees1.Add(new Employee(3, "Lana", "Steen", "33333333", 5000));
            employees1.Add(new Employee(4, "Lana", "Steen", "44444444", 5000));
            employees1.Add(new Employee(5, "Lana", "Steen", "55555555", 5000));
            employees1.Add(new Employee(6, "Lana", "Steen", "66666666", 5000));
            employees1.Add(new Employee(7, "Lana", "Steen", "77777777", 5000));
            employees1.Add(new Employee(8, "Lana", "Steen", "88888888", 5000));
            employees1.Add(new Employee(9, "Lana", "Steen", "99999999", 5000));

            List<Employee> employees2 = new List<Employee>();
            employees2.Add(new Employee(1, "Jane", "Smith", "000000001", 5000));
            employees2.Add(new Employee(2, "John", "Smith", "000000002", 5000));
            employees2.Add(new Employee(3, "Lana", "Steen", "000000003", 5000));
            employees2.Add(new Employee(4, "Lana", "Steen", "000000004", 5000));
            employees2.Add(new Employee(5, "Lana", "Steen", "000000005", 5000));
            employees2.Add(new Employee(6, "Lana", "Steen", "000000006", 5000));
            employees2.Add(new Employee(7, "Lana", "Steen", "000000007", 5000));
            employees2.Add(new Employee(8, "Lana", "Steen", "000000008", 5000));
            employees2.Add(new Employee(9, "Lana", "Steen", "000000009", 5000));


        

            Department Management = new Department("Management", 5);
            employees2.ForEach(a =>  {Management.AddEmployee(a);});

            Department ITDep = new Department("IT", 6);
            employees1.ForEach(a =>  {ITDep.AddEmployee(a);});

            var it1 = ITDep.EmpList;
            var man1 = Management.EmpList;
    



            List<Department> departments = new List<Department>();
            departments.Add(ITDep);
            departments.Add(Management);

            Console.WriteLine();
            Console.WriteLine("List of Departments");
            Department.PrintDeps(departments);
         

            Console.WriteLine();
            Console.WriteLine("Number of Employees in departments");
            foreach (Department department in departments)
            {
                Department.PrintCountEmps(department);
            }
      

            Console.WriteLine();
            Console.WriteLine("List of departments with employees info");
            Department.PrintDepsInfo(departments);



            ITDep.DeleteEmployee(1);
            var it2 = ITDep.EmpList;

            Management.DeleteEmployee(1);
            var man2 = Management.EmpList;

            Console.WriteLine();
            Console.WriteLine("After Delete ");
            Console.WriteLine("Number of Employees");
            foreach (Department department in departments)
            {
                Department.PrintCountEmps(department);
            }

            Console.WriteLine();
            Console.WriteLine("List of departments with employees");
            Department.PrintDepsInfo(departments);


        }
    }
}
