using EmployeeManagement.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeManagement.JsonManager
{
    // This class is more or less meant to mimic saving and loading Employee data from a database
    class JsonManagerService
    {
        private const string SAVE_FILE_BASENAME = @"EMPLOYEEDATA.json";
        private const string SAVE_PATH = @"D:\temp\";
        private string jsonFilePath = SAVE_PATH + SAVE_FILE_BASENAME;

        public void Save(ICollection<Employee> employeeList)
        {
            PrepEntriesForInsertAndUpdate(employeeList);
            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(employeeList));
        }

        private void PrepEntriesForInsertAndUpdate(ICollection<Employee> employeeList)
        {
            foreach (var employee in employeeList)
            {
                if (employee.Id == default(Guid))
                    employee.PrepEntryForInsert();
                else
                    employee.PrepEntryForUpdate();
            }
        }

        // If the database file exists, load the data. Otherwise, return an empty list.
        public ICollection<Employee> Load()
        {
            var employeeList = new List<Employee>();

            if (File.Exists(jsonFilePath))
            {    
                using (var sr = new StreamReader(jsonFilePath))
                {
                    var jsonString = sr.ReadToEnd();
                    var deserializedEmployeeList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                    employeeList = deserializedEmployeeList;
                }
            }

            return employeeList;
        }
    }
}