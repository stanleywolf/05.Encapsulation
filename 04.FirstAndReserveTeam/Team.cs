using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    private List<Person> firstTeam;
    private List<Person> reverseTeam;
    private string  name;

    public string  Name
    {
        get { return name; }
        set { name = value; }
    }
    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return firstTeam; }       
    }
    public IReadOnlyCollection<Person> ReverseTeam
    {
        get { return reverseTeam; }       
    }

    public Team(string name)
    {
        this.name = name;
        firstTeam = new List<Person>();
        reverseTeam = new List<Person>();
    }
    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reverseTeam.Add(person);
        }
    }
}