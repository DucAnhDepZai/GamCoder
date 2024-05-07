using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float maxtop;
    [SerializeField]
    private float maxbottom;
    [SerializeField]
    private float maxleft;
    [SerializeField]
    private float maxright;
    public GameObject cloud;
    private Vector3 target ;

    private void Awake()
    {
         target = cloud.transform.position;
    }
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
       CloudMove();
    
    }
    
    public void CloudMove()
    {
        if (Output.sysOut == "Up")
        {
            if (Output.sysChange)
            {
                Output.sysChange = false;
                target = cloud.transform.position + new Vector3(0, 5, 0);
            }         
            MoveUp();
        }
        if (Output.sysOut == "Right")
        {

            if (Output.sysChange)
            {
                Output.sysChange = false;
                target = cloud.transform.position + new Vector3(5, 0, 0);
            }
            
            MoveRight();
        }
        if (Output.sysOut == "Left")
        {

            if (Output.sysChange)
            {
                Output.sysChange = false;
                target = cloud.transform.position - new Vector3(5, 0, 0);
            }

            MoveLeft();
        }
        if (Output.sysOut == "Down")
        {

            if (Output.sysChange)
            {
                Output.sysChange = false;
                target = cloud.transform.position - new Vector3(0, 5, 0);
            }

            MoveDown();
        }
    }
    public void MoveRight()
    {
        target.x = Min(target.x, maxright);
        if(target.x > cloud.transform.position.x) 
         cloud.transform.position += new Vector3(1.1f, 0,  0) * Time.deltaTime ;
    }
    public void MoveUp()
    {
        target.y = Min(target.y, maxtop);
        if (target.y > cloud.transform.position.y)
            cloud.transform.position += new Vector3(0, 1.1f, 0) * Time.deltaTime ;
        
    }
    public void MoveLeft()
    {
        target.x = Max(target.x, maxleft);
        if (target.x < cloud.transform.position.x)
            cloud.transform.position -= new Vector3(1.1f, 0, 0) * Time.deltaTime;
    }
    public void MoveDown()
    {
        target.y = Max(target.y, maxbottom);
        if (target.y < cloud.transform.position.y)
            cloud.transform.position -= new Vector3(0, 1.1f, 0) * Time.deltaTime;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
    private float Min(float a, float b)
    {
        if (a < b) return a;
        return b;
    }
    private float Max(float a, float b)
    {
        if (a > b) return a;
        return b;
    }
}
