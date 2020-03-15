using EmployeeManagement.DataModels;
using System.Collections.Generic;

namespace EmployeeManagement
{
    public class EmployeeCensusProcessor
    {
        public ICollection<Employee> EmployeeList;
        public ICollection<Employee> DemographicEmployeeList;
        public string censusFilePath;
        public bool reportOnly;
    }
}