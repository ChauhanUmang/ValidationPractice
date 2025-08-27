using ValidationPract.Models;

Console.WriteLine("Start!");

Employee emp = new();

// This is working because C# is assigning default values to properties
// of the object emp. And our validation gets triggered only when we manually
// set some value for the property.
// In this case, our validation is not even getting triggered.

// To fix this or enforce this "required" check on FirstName, we can 
// 1. use required keyword
// 2. use constructor

// try
// {
//     emp.FirstName = "John";
//     emp.WorkExperienceInYears = -1;
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

Console.WriteLine("End!");