using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControler : MonoBehaviour
{
    private void Awake()
    {
        
    }
    List<int> sceneList = new List<int>();
    public void Turtorial()
    { 
        
        SceneManager.LoadScene("Courses");
    }
    public void Challenge()
    {
       
        SceneManager.LoadScene("Training");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Login");
    }
    public void ExitApp()
    {
        Application.Quit();
    }

}
