using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Guard : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D guardBox;
    private void Awake()
    {
        guardBox = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filePath = documentsPath + @"\Result.txt";
        string output = "";


        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                output = sr.ReadToEnd();
            }
        }
        catch (Exception e)
        {
            Debug.Log("EROR: " + e.Message);
        }

        Console.ReadKey();
        Debug.Log(output);
        if (collision.gameObject.GetComponent<Player>())
        {
            if (output == "Hello World")
            {
                guardBox.isTrigger = true;
            }

        }
    }
}
