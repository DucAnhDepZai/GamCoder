using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class SubmitBt : MonoBehaviour
{
    public UnityEngine.UI.InputField txt;
    public TextMeshProUGUI Ptext;
    public GameObject t;
    
    private float time = 0;
    // Start is called before the first frame update
   
    private void Start()
    {

    }
    private void Update()
    {
        if (time < Time.fixedTime)
        {
            
            t.SetActive(false);
        }
        else
        {
            t.SetActive(true);
        }
    }
    public void OCbt()
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        string fileName = documentsPath + "\\test.cpp";
        string scene = SceneManager.GetActiveScene().name;

        string content = BaseScript.GetFS()[scene] + txt.text + BaseScript.GetES()[scene];
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(content);
        }

        Console.ReadKey();

        // Đường dẫn đến trình biên dịch C++ 
        string compiler = "C:\\MinGW\\bin\\g++.exe";
        // Tham số để biên dịch tệp .cpp thành tệp .exe
        string arguments = "-o " + documentsPath + "\\test.exe " + fileName;

        // Tạo một quy trình mới để chạy trình biên dịch
        Process compilerProcess = new Process();
        compilerProcess.StartInfo.FileName = compiler;
        compilerProcess.StartInfo.Arguments = arguments;
        compilerProcess.StartInfo.UseShellExecute = false;
        compilerProcess.StartInfo.RedirectStandardOutput = true;
        compilerProcess.StartInfo.RedirectStandardError = true;

        // Bắt đầu chạy quy trình và đợi cho đến khi quy trình hoàn thành
        compilerProcess.Start();
        compilerProcess.WaitForExit();


        compiler = documentsPath + "\\test.exe";
        // Tham số để biên dịch tệp .cpp thành tệp .exe
        arguments = "-n";

        // Tạo một quy trình mới để chạy trình biên dịch
        Process compilerProcess2 = new Process();
        compilerProcess2.StartInfo.FileName = compiler;
        compilerProcess2.StartInfo.Arguments = arguments;
        compilerProcess2.StartInfo.UseShellExecute = false;
        compilerProcess2.StartInfo.RedirectStandardOutput = true;
        compilerProcess2.StartInfo.RedirectStandardError = true;

        // Bắt đầu chạy quy trình và đợi cho đến khi quy trình hoàn thành
        compilerProcess2.Start();

        string output = compilerProcess2.StandardOutput.ReadToEnd();
        string error = compilerProcess2.StandardError.ReadToEnd();
        
        Ptext.text = output;
        Output.sysOut = output;
        Debug.Log(output);
        Output.sysChange = true;
        time = Time.fixedTime + 4;
       
        compilerProcess2.WaitForExit();
        using (StreamWriter writer = new StreamWriter(documentsPath + "\\Result.txt"))
        {
            writer.Write(output);
        }


    }
}
