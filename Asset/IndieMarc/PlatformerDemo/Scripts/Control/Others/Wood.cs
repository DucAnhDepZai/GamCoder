using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public GameObject wood;
    public int maxLength;
    public int minLength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (int.TryParse(Output.sysOut, out int value))
        {
            int x = int.Parse(Output.sysOut);
            if (Output.sysChange)
            {
                Output.sysChange = false;
                
            }
            if(wood.transform.localScale.x < x && wood.transform.localScale.x < maxLength)
            {
                wood.transform.localScale += new Vector3(0.7f, 0, 0) * Time.deltaTime;
            }
            else if(wood.transform.localScale.x > x && wood.transform.localScale.x > minLength)
            {
                wood.transform.localScale -= new Vector3(0.7f, 0, 0) * Time.deltaTime;
            }
          
        }
    }
    int Max(int a,int b)
    {
        if (a > b) return a;
        return b;
    }
    int Min(int a, int b)
    {
        if (a < b) return a;
        return b;
    }
}
