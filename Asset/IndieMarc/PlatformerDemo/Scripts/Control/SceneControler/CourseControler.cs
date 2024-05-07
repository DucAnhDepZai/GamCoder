using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CourseControler : MonoBehaviour
{
    private void Awake()
    {
        User.loadData();
        
    }
    // Start is called before the first frame update
    //
    public void BeginnerCpp()
    {
        SceneManager.LoadScene("CourseC++");
    }
    public void X()
    {
        SceneManager.LoadScene("MenuGame");
    }
    
}
