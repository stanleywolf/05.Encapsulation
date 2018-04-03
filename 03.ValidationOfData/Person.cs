using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private const decimal MIN_SALARY = 460;
    private const int MIN_LENGHT = 3;

    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < MIN_SALARY)
                throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
            salary = value;
        }
    }
    public string FirstName
    {
        get { return firstName; }
        set
        {
            ValidateFieldName(value , "First name");
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            ValidateFieldName(value, "Last name");
            lastName = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            age = value;
        }
    }
    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
    public Person(string firstName, string lastName, int age, decimal salary) : this(firstName, lastName, age)
    {
        this.Salary = salary;
    }

    public void IncreaceSalary(decimal percentage)
    {
        if (this.age > 30)
        {
            salary = salary + salary * (percentage / 100);
        }
        else
        {
            salary = salary + salary * (percentage / 200);
        }
    }

    private void ValidateFieldName(string fieldValue, string fieldName)
    {
        if(fieldValue?.Length < MIN_LENGHT)
        {
            throw new ArgumentException(fieldName + $" cannot contain fewer than {MIN_LENGHT} symbols!");
        }
    }
    public override string ToString()
    {
        return $"{firstName} {lastName} recieves {salary:f2} leva.";
    }
}