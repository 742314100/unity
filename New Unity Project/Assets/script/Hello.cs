using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("这是我的第一个游1戏");
        Application.targetFrameRate = 50;
        //SpriteRenderer renderer = this.gameObject.GetComponent<SpriteRenderer>();
        //SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        //renderer.flipY = true;
        //获取其他节点
        //GameObject obj = GameObject.Find("/2");
        //SpriteRenderer comp = obj.GetComponent<SpriteRenderer>();
        //comp.flipY = true;

        //GameObject parent = this.transform.parent.gameObject;
       // Debug.Log(parent.name);

        GameObject parent = this.transform.parent.gameObject;
        Debug.Log(parent.name);

	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("123；"+Time.deltaTime);
        //float step = 0.8f * Time.deltaTime;

        //this.transform.Translate(0, step ,0);
        
	}
}
