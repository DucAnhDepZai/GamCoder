using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treasure : MonoBehaviour
{
    public GameObject SuccesPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        if (collision.gameObject.GetComponent<Player>())
        {
            SuccesPanel.SetActive(true);
            //Update Progress
            string scene = SceneManager.GetActiveScene().name;
            Course.GetSubjectByScene(scene).done = true;
            
            int i = findIndex(scene)[0];
            int j = findIndex(scene)[1];
            User.sysUser.progress.Add(new Pair<int, int> { First = i, Second = j});
            string userJson = JsonConvert.SerializeObject(User.users);
            Debug.Log(userJson);
            StartCoroutine(DAO.UpdateJsonUser(userJson));
            Output.sysOut = "";
        }
    }
    private int[] findIndex(string name)
    {
        int[] a = new int[2];
        for(int i = 0; i < Course.sysCourse.lessons.Count; i++)
        {
            for(int j = 0; j < Course.sysCourse.lessons[i].subjects.Count; j++)
            {
                if (Course.sysCourse.lessons[i].subjects[j].scene.Equals(name))
                {
                    a[0] = i;
                    a[1] = j;
                }
            }
        }
        return a;
    }
}
