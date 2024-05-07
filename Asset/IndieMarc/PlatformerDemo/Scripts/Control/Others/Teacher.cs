using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;



public class Teacher : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator Anim;
    private Transform gate; 
    public static bool ktra = false;
    private void Awake()
    {       
         

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //string filePath = @"E:\Result.txt";
        //string output = "";

       
        //try
        //{
        //    using (StreamReader sr = new StreamReader(filePath))
        //    {
        //        output = sr.ReadToEnd();             
        //    }
        //}
        //catch (Exception e)
        //{
        //    Debug.Log("EROR: " + e.Message);
        //}

        //Console.ReadKey();
        //Debug.Log(output);
        //if (collision.gameObject.GetComponent<Player>() && !ktra)
        //{
        //    if (output == "Hello Teacher") 
        //    {
        //        ktra = true;
        //        Debug.Log("Turned on");
        //    }
            
        //}
        
        
    }
    //void CheckGate()
    //{
        

    //    if (ktra &&  gate.position.y <13 )
    //    {
    //        gate.position += new Vector3(0f, 1f, 0f) * Time.deltaTime;
    //        //gate.Rotate(0, 0, 0.5f);
    //    }
    //}
}
