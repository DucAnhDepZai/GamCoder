
using System.Collections.Generic;

public class Course 
{
    public static Course sysCourse;
    public int id { get; set; }
    public string name { get; set; }

    public List<Lesson> lessons { get; set; }

    public Course() { }
    public Course(int id, string name, List<Lesson> lessons)
    {
        this.id = id;
        this.name = name;
        this.lessons = lessons;
    }

    public static Subject GetSubjectByScene(string name)
    {
        foreach(var i in sysCourse.lessons)
        {
            foreach(var j in i.subjects)
            {
                if(j.scene.Equals(name)) return j;
            }
        }
        return null;
    }
   
    public static Lesson GetLessontByScene(string name)
    {
        foreach (var i in sysCourse.lessons)
        {           
            if (i.name.Equals(name)) return i;
            
        }
        return null;
    }
}
