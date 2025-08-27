using ValidationPract.Models;

Console.WriteLine("Start!");

Employee emp = new();

try
{
    emp.FirstName = "";
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("End!");