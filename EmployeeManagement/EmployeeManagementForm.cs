using EmployeeManagement.FileManagers;
using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeManagementForm : Form
    {
        GenerateFileService fileService = new GenerateFileService();
        CensusLoadService censusLoadService = new CensusLoadService();
        EmployeeCensusProcessor _censusProcessor;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            _censusProcessor = fileService.censusProcessor;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            fileService.CreateCSVOfDatabaseState();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (_censusProcessor.reportOnly)
            {

            }
            else
            {

            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _censusProcessor.censusFilePath = openFileDialog.FileName;
                }

                censusLoadService.isFileFormatCorrect(_censusProcessor.censusFilePath);
                filePathTextbox.Text = _censusProcessor.censusFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _censusProcessor.censusFilePath = string.Empty;
            }
        }

        private void reportOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reportOnlyCheckBox.Checked)
                _censusProcessor.reportOnly = true;
            else
                _censusProcessor.reportOnly = false;
        }
    }
}