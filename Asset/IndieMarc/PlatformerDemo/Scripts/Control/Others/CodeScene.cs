using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CodeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inputField;
    public GameObject img;  
    public Player player;
   

    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }
    public void Enable ()
    {
       
        if (!inputField.activeSelf) { 
            
            inputField.SetActive(true);
            img.SetActive(true);
            player.setCanMove(false);
        }
        else
        {
            inputField.SetActive(false);
            img.SetActive(false);
            player.setCanMove(true);
        }
    }
   
}
