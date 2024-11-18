using AcademyDB;
using AcademyDB.Helpers;

SqlQueries.InsertData("INSERT INTO Students (FirstName,LastName, DataOfBirth, EnrollmentDate)\r\nVALUES ('Fuad' , 'Hesenov', '2004-09-06', '2024-09-30'), ('Xeyale' , 'Abbasova', '2004-10-06', '2024-09-30')");


string selectQuery = "SELECT Id, FirstName AS Name FROM Students";
SqlQueries.GetData(selectQuery);


string updateCommand = "UPDATE Students SET FirtsName = 'Ferid', LastName= 'Hesenov' WHERE Id = 30";
SqlQueries.UpdateData(updateCommand);


string deleteCommand = "DELETE FROM Students WHERE Id = 26";
SqlQueries.DeleteData(deleteCommand);   