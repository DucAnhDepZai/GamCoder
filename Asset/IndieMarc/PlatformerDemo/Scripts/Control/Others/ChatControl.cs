using Google.Apis.Json;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChatControl : MonoBehaviour
{
    public TextMeshProUGUI Chat;
    private string scene;
    // Start is called before the first frame update
    static List<string> ds;
    private static int i = 0;
    private void Awake()
    {
        i = 0;
        scene = SceneManager.GetActiveScene().name;       
        ds = Course.GetSubjectByScene(scene).chat;
        Chat.text = ds[0];
    }
    private void Update()
    {
        
    }
    public void NextTextBut()
    {
        if(i < ds.Count -1)
        {
            i++;
            Chat.text = ds[i];
        }
    }
    public void PreTextBut()
    {
        if (i > 0)
        {
            i--;
            Chat.text = ds[i];
        }
    }
   

}
