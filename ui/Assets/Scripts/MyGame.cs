using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGame : MonoBehaviour {

    public InputField userField; //指向了用户名下面的InputField组件

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Login()
    {
        string user = userField.text;
        Debug.Log("登录中。。。"+user);
    }

}
