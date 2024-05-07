
using System.Collections.Generic;

public class Lesson 
{
    public int id {  get; set; }
    public string name { get; set; }

    public List<Subject> subjects { get; set; }

    public Lesson(int id, string name, List<Subject> subjects)
    {
        this.id = id;
        this.name = name;
        this.subjects = subjects;
    }
    public Lesson() { }
    
}
