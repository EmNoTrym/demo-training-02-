using System;

var A_string = "A String";
var A_int = 69;
var A_long = 6969696969;
var A_float = 6.9f;
var A_bool = true;

struct Sex
{
    public string male;
    public string female;
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string GetName()
    {
        return this.Name;
    }

    public string GetName()
    {
        return this.Name;
    }
}

enum Jobs
{
    Doctor,
    Coder,
    Developer,
    Builder
}