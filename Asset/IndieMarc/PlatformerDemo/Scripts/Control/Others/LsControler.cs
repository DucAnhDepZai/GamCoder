using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LsControler : MonoBehaviour
{
    public int start = 0;
    public GameObject lv1;
    public GameObject lv2;
    public GameObject lv3;
    public GameObject lv4;
    public GameObject lv5;
    private void Awake()
    {
        Lesson l = Course.GetLessontByScene(SceneManager.GetActiveScene().name);    
        lv2.GetComponent<Button>().interactable = l.subjects[start++].done;
        lv3.GetComponent<Button>().interactable = l.subjects[start++].done;
        lv4.GetComponent<Button>().interactable = l.subjects[start++].done;
        lv5.GetComponent<Button>().interactable = l.subjects[start++].done;

    }
    // Start is called before the first frame update
    public void Lvl1()
    {
        SceneManager.LoadScene("A_Level1");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("A_Level2");
    }
    public void Lvl3()
    {
        SceneManager.LoadScene("A_Level3");
    }
    public void Lvl4()
    {
        SceneManager.LoadScene("A_Level4");
    }
    public void Lvl9()
    {
        SceneManager.LoadScene("A_Level9");
    }
  
    public void buttonX()
    {
        SceneManager.LoadScene("CourseC++");
    }
}
