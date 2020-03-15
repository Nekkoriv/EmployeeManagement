using EmployeeManagement.DataModels;
using System;
using System.Collections.Generic;

namespace EmployeeManagement.StaticDetails
{
    public static class MockEmployees
    {
        public static ICollection<Employee> GetMockEmployees()
        {
            var mockEmployees = new List<Employee>();

            mockEmployees.Add
                (
                    new Employee
                    (
                        "Paul",
                        "Aber",
                        "6 Starboard Street",
                        "lilJohnnyTables@mail.com",
                        new DateTime(1965, 10, 05),
                        "Database Administrator",
                        Employee.EmploymentStatusEnum.Active,
                        103000,
                        new DateTime(2005, 03, 20)
                    )
                );

            mockEmployees.Add
                (
                    new Employee
                    (
                        "James",
                        "Oglethorpe",
                        "50 Washington Avenue",
                        "starsandstripes1776@aol.com",
                        new DateTime(1696, 12, 22),
                        "Statesman",
                        Employee.EmploymentStatusEnum.Active,
                        45000f,
                        new DateTime(2019, 09, 15)
                    )
                );

            mockEmployees.Add
                (
                    new Employee
                    (
                        "Roger",
                        "Bacon",
                        "19 Brood Street",
                        "xslayerx666@hotmail.com",
                        new DateTime(1993, 10, 05),
                        "Courier",
                        Employee.EmploymentStatusEnum.Terminated,
                        15000f,
                        new DateTime(2019, 05, 18),
                        new DateTime(2019, 06, 13)
                    )
                );

            mockEmployees.Add
                (
                    new Employee
                    (
                        "James",
                        "Punto",
                        "26 Brood Street",
                        "whatdidyalearn@gmail.com",
                        new DateTime(1958, 04, 04),
                        "Director of Dining Services",
                        Employee.EmploymentStatusEnum.Active,
                        80000f,
                        new DateTime(2014, 04, 04)
                    )
                );

            mockEmployees.Add
                (
                    new Employee
                    (
                        "Lil",
                        "Tay",
                        "205 Wealth Circle",
                        "fbgmworldwide@gmail.com",
                        new DateTime(2007, 07, 29),
                        "Mascot",
                        Employee.EmploymentStatusEnum.Active,
                        30000f,
                        new DateTime(2018, 04, 04)
                    )
                );

            return mockEmployees;
        }
    }
}