using System;
using System.Dynamic;

namespace ValidationPract.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int WorkExperienceInYears { get; set; }
    public DateTime DateOfBirth { get; set; }
    public double Salary { get; set; }
}
