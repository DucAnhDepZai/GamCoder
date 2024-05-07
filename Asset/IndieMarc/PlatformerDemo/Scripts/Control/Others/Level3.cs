using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wood1;
    public GameObject wood2;
    public GameObject wood3;
    private static string[] s = new string[3] {"1","1","1"};
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            s = Output.sysOut.Split(' ');
            
            if (int.TryParse(s[0], out int value) && int.TryParse(s[1], out int value1) && int.TryParse(s[2], out int value2))
            {
                if (Output.sysChange)
                {
                    Output.sysChange = false;

                }
                if (wood1.transform.localScale.y < value)
                {
                    wood1.transform.localScale += new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                }
                else
                {
                    wood1.transform.localScale -= new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                }

                if (wood2.transform.localScale.y < value1)
                {
                    wood2.transform.localScale += new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                }
                else
                {
                    wood2.transform.localScale -= new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                }

                if (wood3.transform.localScale.y < value2)
                {
                    wood3.transform.localScale += new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                }
                else
                {
                    wood3.transform.localScale -= new Vector3(0f, 0.7f, 0) * Time.deltaTime;
                }

            }
        }
        catch { }
    }
}
