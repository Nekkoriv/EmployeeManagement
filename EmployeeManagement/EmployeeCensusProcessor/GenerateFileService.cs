using EmployeeManagement.DataModels;
using EmployeeManagement.StaticDetails;
using EmployeeManagement.FileManagers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EmployeeManagement.EmployeeCensusProcessor
{
    class GenerateFileService
    {
        private const string savePath = @"D:\temp\";
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
            var jsonManager = new JsonManagerService(savePath);

            jsonManager.Save(employeeList);
        }

        // The Load method in JsonManagerService will return an empty list if the database file cannot be found.
        // LoadEmployeeListToJson should return true if the list is populated and false if it is not.
        private bool LoadEmployeeListToJson()
        {
            var jsonManager = new JsonManagerService(savePath);
            employeeList = jsonManager.Load();

            if (employeeList.Any())
                return true;
            return false;
        }

        private void CreateCSVOfDatabaseState()
        {
            var dataReportManager = new DataReportManagerService();
            dataReportManager.CreateDataReport(savePath, employeeList);
        }
    }
}