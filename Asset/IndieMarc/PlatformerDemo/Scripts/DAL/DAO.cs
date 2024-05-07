
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SimpleJSON;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class DAO : MonoBehaviour
{
    
    private const string TableUserId = "6465dff68e4aa6225e9f3613"; 
    private const string TableDataId = "646a697db89b1e2299a20811";
    private const string secretKey = "$2b$10$Xnl68uz9iOodlqlrocjnMuTrpB0LHpqnL15ZUypEj4oY7eOZ9SWZG"; // Khóa bí mật của bạn trên JSONBin.io
    private const string GetUserUrl = "https://api.jsonbin.io/v3/b/" + TableUserId +"/latest";
    private const string GetDataUrl = "https://api.jsonbin.io/v3/b/" + TableDataId + "/latest";
    private const string PutUserUrl = "https://api.jsonbin.io/v3/b/" + TableUserId;
    private const string PutDataUrl = "https://api.jsonbin.io/v3/b/" + TableDataId;
    

    public static string json = "none";
    public static IEnumerator GetJsonUser()
    {
       
        UnityWebRequest request = UnityWebRequest.Get(GetUserUrl);
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("X-Master-Key", secretKey);

        yield return request.SendWebRequest();
        
        if (request.result == UnityWebRequest.Result.Success)
        {
            
            json = request.downloadHandler.text;
            var data = JSON.Parse(json);
            json = "";
            foreach ( var i in data["record"] ) 
            {
                string user = JSON.Parse(i.Value["username"]);
                string pass = JSON.Parse(i.Value["password"]);
                string r = JSON.Parse(i.Value["role"]);
                List<Pair<int,int>> prog = JsonConvert.DeserializeObject<List<Pair<int, int>>>(i.Value["progress"].ToString());
                User.users.Add(new User { username = user , password = pass , role = r, progress = prog });
            }
            Debug.Log("Succeed to get datas");
        }
        else
        {
            json = "Lỗi: " + request.error;
        }
    }
    public static IEnumerator GetJsonData()
    {

        UnityWebRequest request = UnityWebRequest.Get(GetDataUrl);
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("X-Master-Key", secretKey);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {

            json = request.downloadHandler.text;
            var data = JSON.Parse(json);
            
            string j = data["record"].ToString();
            Course.sysCourse = JsonConvert.DeserializeObject<Course>(j);
            
            Debug.Log("Lấy dữ liệu thành công! ");
        }
        else
        {
            json = "Lỗi: " + request.error;
        }
    }
    public static IEnumerator UpdateJsonUser(string newJsonData)
    {
        
        UnityWebRequest request = UnityWebRequest.Put(PutUserUrl, newJsonData);
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("X-Master-Key", secretKey);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Đăng kí thàng công!");

        }
        else
        {
            Debug.Log("Lỗi: " + request.error);
        }
    }
    
    public static IEnumerator UpdateJsonData(string newJsonData)
    {

        UnityWebRequest request = UnityWebRequest.Put(PutDataUrl, newJsonData);
        request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("X-Master-Key", secretKey);
       
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Cập nhật thành công!");

        }
        else
        {
            Debug.Log("Lỗi: " + request.error);
        }
    }
}
