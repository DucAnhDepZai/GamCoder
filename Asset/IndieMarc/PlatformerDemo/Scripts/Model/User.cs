using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User 
{
    public static User sysUser;
   
    public static List<User> users = new List<User>();
    public string username { get; set; }
    public string password { get; set; }
    public string role { get; set; }
    public List<Pair<int,int>> progress { set; get; }
    public User() {

    }
    public User(string username, string password, List<Pair<int, int>> progress)
    {
        this.username = username;
        this.password = password;
        this.role = "user";
        this.progress = progress;
    }

    public static void loadData()
    {
        foreach (var i in sysUser.progress) 
        {
            Course.sysCourse.lessons[i.First].subjects[i.Second].done = true;
        }
    }
}
