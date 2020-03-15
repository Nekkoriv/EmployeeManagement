using EmployeeManagement.EmployeeCensusProcessor;
using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeManagementForm : Form
    {
        GenerateFileService fileService = new GenerateFileService();
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            fileService.CreateCSVOfDatabaseState();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (reportOnlyCheckBox.Checked)
            {

            }
            else
            {

            }
        }
    }
}