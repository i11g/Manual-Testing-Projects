using System.Runtime.CompilerServices;

Person person = new Person()
{
    Age = -8,
    Name="Iv"
    
};

person.Name= "Test";

public class Person
{
    private string name;
    private int age; 

    //public Person(string name, int age)
    //{
    //    this.name = name;
    //    this.age = age;
    //}

    public string Name 
    {
        get { return this.name; } 
        set 
        { 
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is not valid"); 
            }
            name = value; 
        } 
    }
    public int Age 
    {
        get { return this.age; } 
        set 
        { 
            if(value<0)
            {
                throw new ArgumentException("Age cannot be negative");
            }           
            age = value; 
        
        } 
    }
}