using System;
using System.IO;

namespace EmployeeManagement.FileManagers
{
    public class CensusLoadService
    {
        public bool isFileFormatCorrect(string censusFilePath)
        {
            FileInfo fi = new FileInfo(censusFilePath);
            if (fi.Extension != ".csv")
            {
                throw new Exception($"{censusFilePath} is not a CSV file.");
            }
            return true;
        }
    }
}