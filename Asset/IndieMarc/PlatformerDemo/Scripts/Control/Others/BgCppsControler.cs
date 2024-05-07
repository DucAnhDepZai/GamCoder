using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgCppsControler : MonoBehaviour
{
    public void Variable()
    {
        SceneManager.LoadScene("Variables and Datatypes");
    }
    public void Select()
    {
        SceneManager.LoadScene("Selection statements");
    }
    public void loops()
    {
        SceneManager.LoadScene("Loops");
    }
    public void buttonX()
    {
        SceneManager.LoadScene("Courses");
    }
}
