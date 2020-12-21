using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(Input.GetMouseButton(0))
        {
            //Invoke("Response",3); //延迟3秒执行

            InvokeRepeating("Response",1,3); //延迟1秒执行，间隔3秒重复执行
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Response()
    {
        Debug.Log("invoke");
    }

}
