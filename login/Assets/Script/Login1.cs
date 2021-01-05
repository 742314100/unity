using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login1 : MonoBehaviour
{

    //Toggle
    public Toggle remPasswd;
    public Toggle fogPasswd;

    //注册信息
    public InputField inputName;
    public InputField inputPasswd;

    private string url = "http://localhost:3000/";

    public void userRegeste()
    {
        if (inputName.text.Trim() != "" && inputPasswd.text.Trim() != "")
        {
            this.TestHttpSend("register");
            
        }
        else
        {
            Debug.Log("请输入用户名或者密码");
        }

    }
    public void userLogin()
    {
        if (inputName.text.Trim() != "" && inputPasswd.text.Trim() != "")
        {
            this.TestHttpSendGet("login", inputName.text, inputPasswd.text); //get 

        }
        else
        {
            Debug.Log("请输入用户名或者密码");
        }

    }

    //get方法
    IEnumerator SendGet(string _url)
    {
        WWW getData = new WWW(_url);
        yield return getData;
        if (getData.error != null)
        {
            Debug.Log(getData.error);
        }
        else
        {
            Debug.Log(getData.text);
        }
    }

    //post 方法
    IEnumerator SendPost(string _url, WWWForm _wForm)
    {
        WWW postData = new WWW(_url, _wForm);
        yield return postData;
        if (postData.error != null)
        {
            Debug.Log(postData.error);
        }
        else
        {
            Debug.Log(postData.text);
        }
    }


    //调用get 
    public void TestHttpSendGet(string type,string userName,string passWord)
    {
        Debug.Log(url +type+ "?userName="+userName+"&passWord="+passWord);
        StartCoroutine(SendGet(url + type + "?userName=" + userName + "&passWord=" + passWord));
    }
    //调用post
    public void TestHttpSend(string type)
    {
        WWWForm form = new WWWForm();
        form.AddField("userName", inputName.text);
        form.AddField("passWord", inputPasswd.text);
        StartCoroutine(SendPost(url + type, form));
    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //选中记住密码
        if(remPasswd.isOn)
        {
            //填充数据，这里仅仅是模拟
            //inputPasswd.text = "admin";
            inputPasswd.text = inputPasswd.text;
        }
        else
        {
            inputPasswd.text = inputPasswd.text;
        }
    }

  

}
