using System;
using System.Dynamic;

namespace ValidationPract.Models;

public class Employee
{
    private string _firstName;

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("FirstName is required.");
            }
            _firstName = value;
        }
    }
    public string LastName { get; set; }
    public int WorkExperienceInYears { get; set; }
    public DateTime DateOfBirth { get; set; }
    public double Salary { get; set; }
}
