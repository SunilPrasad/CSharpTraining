using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightOuterJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Project P1 = new Project() {ProjectID = 1, ProjectName = "UID"};
            Project P2 = new Project() {ProjectID = 2, ProjectName = "RBS"};
            Project P3 = new Project() {ProjectID = 3, ProjectName = "XYZ"};
            Project P4 = new Project() { ProjectID = 5, ProjectName = "ABC" };

            // Employee List
            List<Employee> ListOfEmployees = new List<Employee>();
            ListOfEmployees.AddRange((new Employee[]
            {
                new Employee() {ID = 1, Name = "John", ProjectID = 1},
                new Employee() {ID = 1, Name = "Smith", ProjectID = 1},
                new Employee() {ID = 1, Name = "Rohn", ProjectID = 2},
                new Employee() {ID = 1, Name = "Tim", ProjectID = 3},
                new Employee() {ID = 1, Name = "Jimmy", ProjectID = 4}
            }));

            //Project List
            List<Project> ListOfProject = new List<Project>();
            ListOfProject.AddRange(new Project[] {P1, P2, P3,P4});

            //Left join
            var Ljoin = from emp in ListOfEmployees
                join proj in ListOfProject
                on emp.ProjectID equals proj.ProjectID into JoinedEmpDept
                from proj in JoinedEmpDept.DefaultIfEmpty()
                select new
                {
                    EmployeeName = emp.Name,
                    ProjectName = proj != null ? proj.ProjectName : null
                };

            //Right outer join
            var RJoin = from proj in ListOfProject
                join employee in ListOfEmployees
                on proj.ProjectID equals employee.ProjectID into joinDeptEmp
                from employee in joinDeptEmp.DefaultIfEmpty()
                select new
                {
                    EmployeeName = employee != null ? employee.Name : null, proj.ProjectName
                };

            //Printing result of left join
            //Console.WriteLine(string.Join("\n", Ljoin.Select(emp => " Employee Name = " +
            //                                                        emp.EmployeeName + ", Project Name = " +
            //                                                        emp.ProjectName).ToArray<string>()));

            //printing result of right outer join
            Console.WriteLine(string.Join("\n", RJoin.Select(emp => " Employee Name = " +
                                                                    emp.EmployeeName + ", Project Name = " +
                                                                    emp.ProjectName).ToArray<string>()));

            Console.ReadLine();

        }

    }


    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int ProjectID { get; set; }
    }

    class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
    }
}

