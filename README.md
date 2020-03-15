# EmployeeManagement
This will be a desktop application used for employee management. The data will be saved in a JSON file that will act as a database and updates will come through in the form of a CSV file. The software will then compare differences between the data in the CSV file and the JSON file and make the appropriate updates before resaving to the JSON file.

1. Store data about employees in a Json database file located in C:\temp.
   A. If the database file does not exist in the aforementioned directory, create it.
   B. If the database file does exist in the aforementioned directory, load the data into the program.
2. Allow the user to create a data report in the form of a CSV file. The purpose of this is to show the user the data currently held in the database in a tabular format. This will be stored in the same location as the database file.
3. Allow the user to load a "census file" in the form of a CSV file. The purpose of this is to have the software process changes made to employees in the system.
   A. Changes to employees can only be done via a census file upload.
4. Created and modified dates should be logged for employee entities.
   A. We additionally want to keep all the generated report files. As a means of doing this, we will append the date and time onto the file name for report files in the form yyyyMMddHHmm. Note that if more than one is generated in the same minute, the former will be overwritten. This is fine.
   B. Since the database file is supposed to mimic a database, we do not want to create a new file each time it is updated. As a result, the old file will always be overwritten by a new database file save.
5. We want a report only flag that determines whether or not the current database file should be overwritten.
   A. When that flag is true, create a data report file to show what the new data would look like.
   B. When that flag is false, save the data to the database file without creating a report file.
