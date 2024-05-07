using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using Newtonsoft.Json;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginControler : MonoBehaviour
{
    private const string binId = "6465dff68e4aa6225e9f3613"; // ID của bin JSON trên JSONBin.io
    private const string secretKey = "$2b$10$Xnl68uz9iOodlqlrocjnMuTrpB0LHpqnL15ZUypEj4oY7eOZ9SWZG"; // Khóa bí mật của bạn trên JSONBin.io
    private const string apiUrl = "https://api.jsonbin.io/v3/b/" + binId;
    public TMP_InputField user;
    public TMP_InputField pass;
    public TMP_InputField mess;
    public GameObject m;
    float time;
    private void Start()
    {
       // Course.sysCourse = new Course();

        StartCoroutine(DAO.GetJsonUser());
        StartCoroutine(DAO.GetJsonData());
    }
    private void Update()
    {
       if(time > Time.fixedTime)
       {
            m.SetActive(true);
       }
       else
       {
            m.SetActive(false);
       }
    }
    public void SignIn()
    {
        bool ok = false;
        for (int i = 0; i < User.users.Count; i++)
        {
            {
                if (User.users[i].username == user.text && User.users[i].password == pass.text)
                {
                    ok = true;
                    User.sysUser = User.users[i];
                    mess.text = "Đăng nhập thành công!";
                    time = Time.fixedTime + 2;
                    SceneManager.LoadScene("MenuGame");
                }
            }
            if (!ok)
            {
                mess.text = "Sai tài khoản hoặc mật khẩu! Hãy nhập lại!";
                time = Time.fixedTime + 2;
            }
        }
    }

    public void SignUp()
    {
        string error = checkValidate();
        if(error == null)
        {
            User.users.Add(new User { username = user.text, password = pass.text , role = "user", progress = new List<Pair<int, int>>()});
            string newJsonData = JsonConvert.SerializeObject(User.users);
            Debug.Log(newJsonData);
            StartCoroutine(DAO.UpdateJsonUser(newJsonData));
            mess.text = "Đăng kí thành công";
            time = Time.fixedTime + 2;
        }
        else
        {
           mess.text = error;
            time = Time.fixedTime + 2;
        }
            
    }
    private string checkValidate()
    {
        string name = user.text;
        string p = pass.text;
        if (p.Length < 1)
        {
            return "Mật khẩu không được để trống!";
        }
        if (name.Length < 1)
        {
            return "Tên người dùng không được để trống!";
        }
        if (name.IndexOf(' ') != -1)
        {
            return "Tên không được chứa dấu cách!";
        }
        if (p.IndexOf(' ') != -1)
        {
            return "Mật khẩu không được chứa dấu cách!";
        }
        if (User.users.Count > 0)
        {
            foreach (User i in User.users)
            {
                if (i.username == name) return "Tên người dùng đã được đăng kí! Hãy thử tên khác";
            }
        }
        return null;
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
