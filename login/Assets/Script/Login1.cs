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

    public void OnClick()
    {
        if (inputName.text.Trim() == "liwei" && inputPasswd.text.Trim() == "admin")
        {
            Debug.Log("登录成功");
        }
        else
        {
            Debug.Log("登录失败");
        }

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
            inputPasswd.text = "admin";
        }
        else
        {
            inputPasswd.text = inputPasswd.text;
        }
    }

    void regist()
    { 
        //如果可以直接将数据写入数据库，这里我们仅仅是模拟
        if (inputName.text != "" && inputPasswd.text != "")
        {
            Debug.Log("注册成功");
        }
        else
        {
            Debug.Log("请输入注册信息");
        }
    
    }

}
