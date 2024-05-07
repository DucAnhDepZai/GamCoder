using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public class Level9 : MonoBehaviour
{
    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public GameObject w5;     
    public GameObject w6;
    public GameObject w7;
    public GameObject w8;
    public GameObject w9;
    public GameObject w10;
    public static List<GameObject> woods;
    private static string[] s;
    void Start()
    {
        woods = new List<GameObject> {w1,w2,w3,w4,w5,w6,w7,w8,w9,w10 };
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            s = Output.sysOut.Split(' ');
           
            if (s.Length == 11)
            {
                List<string> a = s.ToList<string>();

                for (int i = 0; i < 10; i++)
                {

                    if (int.TryParse(s[i], out int value))
                    {
                        if (Output.sysChange)
                        {
                            Output.sysChange = false;

                        }
                        if (woods[i].transform.localScale.y < value)
                        {
                            woods[i].transform.localScale += new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                        }
                        else
                        {
                            woods[i].transform.localScale -= new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                        }
                    }
                }
            }
        }
        catch { }
    }
}
