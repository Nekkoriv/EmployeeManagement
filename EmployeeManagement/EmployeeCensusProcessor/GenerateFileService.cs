using EmployeeManagement.DataModels;
using EmployeeManagement.StaticDetails;
using EmployeeManagement.JsonManager;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System;
using System.Linq;

namespace EmployeeManagement.EmployeeCensusProcessor
{
    class GenerateFileService
    {
        private ICollection<Employee> employeeList = new List<Employee>();

        public GenerateFileService()
        {
            // LoadEmployeeListToJson will return true if the employeeList is populated, otherwise it will return false.
            // If the employee list is not populated we want to: load the default data set, seed that data into a database file, populate the employeeList, then create a CSV that represents the data in a tabular format. 
            if (!LoadEmployeeListToJson())
            {
                GetMockData();
                SaveEmployeeListToJson();
                LoadEmployeeListToJson();
            }

            CreateCSVOfDatabaseState();
            Debugger.Break();
        }

        private void GetMockData()
        {
            employeeList = MockEmployees.GetMockEmployees();
        }

        private void SaveEmployeeListToJson()
        {
            var jsonManager = new JsonManagerService();

            jsonManager.Save(employeeList);
        }

        // The Load method in JsonManagerService will return an empty list if the database file cannot be found.
        // LoadEmployeeListToJson should return true if the list is populated and false if it is not.
        private bool LoadEmployeeListToJson()
        {
            var jsonManager = new JsonManagerService();
            employeeList = jsonManager.Load();

            if (employeeList.Any())
                return true;
            return false;
        }

        // Create a CSV file that represents the data from the database file in a tabular format
        private void CreateCSVOfDatabaseState()
        {
            var saveFileName = "EmployeeDataReport" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
            var savePath = @"D:\temp\";
            var report = new List<string>();

            // Create report header
            report.Add(
                "Id," +
                "First Name," +
                "Last Name," +
                "Address," +
                "Email," +
                "Date of Birth," +
                "Job Title," +
                "Employment Status," +
                "Salary," +
                "Hire Date," +
                "Termination Date," +
                "Entity Created Date," +
                "Entity Modified Date");

            // Create a report row for each employee
            foreach (var employee in employeeList)
            {
                // Since termDate is a nullable DateTime, we want to return the value only if it exists so that the application doesn't crash, otherwise we can return an empty string
                var termDate = employee.TermDate.HasValue ? employee.TermDate.Value.ToShortDateString() : string.Empty;

                report.Add(
                    $"{employee.Id}," +
                    $"{employee.FirstName}," +
                    $"{employee.LastName}," +
                    $"{employee.Address}," +
                    $"{employee.Email}," +
                    $"{employee.DateOfBirth.ToShortDateString()}," +
                    $"{employee.JobTitle}," +
                    $"{employee.EmploymentStatus.ToString()}," +
                    $"{employee.Salary}," +
                    $"{employee.HireDate.ToShortDateString()}," +
                    $"{termDate}," +
                    $"{employee.CreatedDate}," +
                    $"{employee.ModifiedDate}");
            }

            File.WriteAllLines(savePath + saveFileName, report);
        }
    }
}