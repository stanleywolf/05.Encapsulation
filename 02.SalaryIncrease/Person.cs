using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public Person(string firstName, string lastName, int age, decimal salary):this(firstName, lastName, age)
    {
        this.salary = salary;
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
    public override string ToString()
    {
        return $"{firstName} {lastName} recieves {salary:f2} leva.";
    }
}