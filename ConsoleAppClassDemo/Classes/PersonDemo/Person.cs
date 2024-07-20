// See https://aka.ms/new-console-template for more information

// Define an object of type person


using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ConsoleAppClassDemo.Classes.PersonDemo;
public partial class Person
{
    public Person()
    {

    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxnumber = taxNumber;
    }
    // Properties / Data Members

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateofBirth { get; set; }

    // feild member
    private string _taxnumber;
    protected static string _idNumber = "N/A";


    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial} {lastInitial}");
    }
    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxnumber))
        {
            _taxnumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        else
        {
            Console.WriteLine($"Tax number already exsists {FirstName}");
        }

    }

    public string GetTaxNumber()
    {
        return _taxnumber;
    }
    public string GetIdNumber()
    {
        return _idNumber;
    }
    
    protected string GetRandomNumber()
    {
        return RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
    }
}



