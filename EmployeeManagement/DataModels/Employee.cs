using System;

namespace EmployeeManagement.DataModels
{
    public class Employee
    {
        #region EmploymentStatusEnum
        public enum EmploymentStatusEnum
        {
            Active,
            Terminated
        }
        #endregion

        #region BoilerPlate
        public Employee()
        {

        }

        public Employee
            (
            string firstName,
            string lastName,
            string address,
            string email,
            DateTime dateOfBirth,
            string jobTitle,
            EmploymentStatusEnum employmentStatus,
            float salary,
            DateTime hireDate,
            DateTime? termDate = null
            )
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            DateOfBirth = dateOfBirth;
            JobTitle = jobTitle;
            EmploymentStatus = employmentStatus;
            Salary = salary;
            HireDate = hireDate;
            TermDate = termDate;
        }
        #endregion

        #region PublicProperties
        // This is set when an entity is saved to the JSON file for the first time
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JobTitle { get; set; }
        public EmploymentStatusEnum EmploymentStatus{ get; set; }
        public float Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TermDate { get; set; }
        // This is set when an entity is saved to the JSON file for the first time
        public DateTime CreatedDate { get; set; }
        // This is updated every time an entry is saved to the JSON file 
        public DateTime ModifiedDate { get; set; }
        #endregion

        public void PrepEntryForInsert()
        {
            var now = DateTime.Now;

            Id = Guid.NewGuid();
            CreatedDate = now;
            ModifiedDate = now;
        }

        public void PrepEntryForUpdate()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}