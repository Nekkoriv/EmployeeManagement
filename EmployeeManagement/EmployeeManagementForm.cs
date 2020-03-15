using EmployeeManagement.EmployeeCensusProcessor;
using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeManagementForm : Form
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var fileService = new GenerateFileService();
        }
    }
}