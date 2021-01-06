using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class IdCard : MonoBehaviour {

    public Text Output;//成功失败的回调
    public InputField Input;//用户输入的身份证号码
    public InputField InputName;//用户输入的姓名
    private string ID;
    
    //点击按钮之后校验
    public void Verification()
    { 
        //将用户输入的身份证号码赋值到string类型的值上去
        if(Input.text.Trim() == "")
        {
            Output.gameObject.SetActive(true);
            Output.text = "请输入身份证！";
            return;
        }
        if (InputName.text.Trim() == "")
        {
            Output.gameObject.SetActive(true);
            Output.text = "请输入姓名！";
            return;
        }

        ID = Input.text.ToString();
        if (ID.Length == 18)
        {
            //验证18位
            Resolution();
            if (!CheckName(InputName.text))
            {
                Output.text = "姓名是不合法！";
            }
       
        }
        else
        {
            //基本验证没有通过，位数多或者少，不合法
            //Debug.Log("身份证验证位数不通过");
            Output.gameObject.SetActive(true);
            Output.text = "身份证验证不通过，原因：身份证位数不够！";

        }

    }

    //基本位数验证通过之后开始拆分计算
    void Resolution()
    {
        //将所输入的身份证号码进行拆分，拆分为17位，最后一位留着待用
        int Num0 = int.Parse(ID.Substring(0, 1)) * 7;
        int Num1 = int.Parse(ID.Substring(1, 1)) * 9;
        int Num2 = int.Parse(ID.Substring(2, 1)) * 10;
        int Num3 = int.Parse(ID.Substring(3, 1)) * 5;
        int Num4 = int.Parse(ID.Substring(4, 1)) * 8;
        int Num5 = int.Parse(ID.Substring(5, 1)) * 4;
        int Num6 = int.Parse(ID.Substring(6, 1)) * 2;
        int Num7 = int.Parse(ID.Substring(7, 1)) * 1;
        int Num8 = int.Parse(ID.Substring(8, 1)) * 6;
        int Num9 = int.Parse(ID.Substring(9, 1)) * 3;
        int Num10 = int.Parse(ID.Substring(10, 1)) * 7;
        int Num11 = int.Parse(ID.Substring(11, 1)) * 9;
        int Num12 = int.Parse(ID.Substring(12, 1)) * 10;
        int Num13 = int.Parse(ID.Substring(13, 1)) * 5;
        int Num14 = int.Parse(ID.Substring(14, 1)) * 8;
        int Num15 = int.Parse(ID.Substring(15, 1)) * 4;
        int Num16 = int.Parse(ID.Substring(16, 1)) * 2;
        int allNum = Num0 + Num1 + Num2 + Num3 + Num4 + Num5 + Num6 + Num7 + Num8 + Num9 + Num10 + Num11 + Num12 + Num13 + Num14 + Num15 + Num16;
        Judge(allNum, ID.Substring(17, 1));
    }

    /// <summary>
/// 计算身份证号码是否合法
/// </summary>
/// <param 前17位相加之和="allNum"></param>
/// <param 身份证号码最后一位="LastNum"></param>
    void Judge(int allNum, string LastNum)
    {

        int Remainder = allNum % 11;
        //如果最后一位数不是X的时候将最后一位数转换为int
        if (Remainder == 0)
        {
            if (int.Parse(LastNum) == 1)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 1)
        {
            if (int.Parse(LastNum) == 0)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 2)
        {
            Debug.Log("最后一位数是X");
            if (LastNum != "x" && LastNum != "X")
            {
                Debug.Log(LastNum);
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
            else
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
        }
        if (Remainder == 3)
        {
            if (int.Parse(LastNum) == 9)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 4)
        {
            if (int.Parse(LastNum) == 8)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 5)
        {
            if (int.Parse(LastNum) == 7)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 6)
        {
            if (int.Parse(LastNum) == 6)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 7)
        {
            if (int.Parse(LastNum) == 5)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 8)
        {
            if (int.Parse(LastNum) == 4)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 9)
        {
            if (int.Parse(LastNum) == 3)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
        if (Remainder == 10)
        {
            if (int.Parse(LastNum) == 2)
            {
                Debug.Log("身份证合法，已经通过验证");
                Output.text = "恭喜验证通过";
            }
            else
            {
                Debug.Log("身份证填写错误");
                Output.text = "您的身份证号不码合法";
            }
        }
    }


    /// <summary>
    /// 检查姓名是否合法
    /// </summary>
    /// <param name="nameStr">要检查的内容</param>
    /// <returns></returns>
    public static bool CheckName(string nameStr) //检查姓名是否合法
    {
        Regex nameReg = new Regex(@"^[\u4e00-\u9fa5]{0,}$");//为汉字
        Regex nameReg2 = new Regex(@"^\w+$");//字母，数字，下划线
        if (nameReg.IsMatch(nameStr) || nameReg2.IsMatch(nameStr))//为汉字或字母
        {
            return true;
        }
        else
        {
            return false;
        }
    }

	// Use this for initialization
	void Start () {
        Output.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
