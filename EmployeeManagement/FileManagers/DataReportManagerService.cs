using EmployeeManagement.DataModels;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeManagement.FileManagers
{
    // This class manages the creation of the DataReport
    public class DataReportManagerService
    {
        // Create a CSV file that represents the data from the database file in a tabular format
        public void CreateDataReport(string savePath, ICollection<Employee> employeeList)
        {
            var saveFileName = "EmployeeDataReport" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";
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