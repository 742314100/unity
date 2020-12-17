using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my : MonoBehaviour {

    private bool upward = true;
    private bool toRight = true;

	// Use this for initialization
	void Start () {
        //transform.position = new Vector3(0,1.0f,0);
       // transform.eulerAngles = new Vector3(0,0,45f);
        //Vector3 a = new Vector3(2,2,0);
        //float length = a.magnitude;
        
        //Vector3 b = a.normalized;

        //Vector3 c = Vector3.up;

        //Debug.Log(b.ToString("F3"));


        //GameObject target = GameObject.Find("ball");

        //Vector3 p2 = target.transform.position;

        //Vector3 p1 = this.transform.position;

        //Vector3 direction = p2 - p1;

        //Debug.Log("飞机和球距离:"+direction.magnitude);

        //Vector3 a = new Vector3(2,2,0);
        //Vector3 b = new Vector3(-1,3,0);
        //float angle = Vector3.Angle(a,b);
        //Debug.Log("夹角是："+angle);

        //Debug.Log("x轴向量：" + transform.right.ToString("F3"));
        //Debug.Log("y轴向量：" + transform.up.ToString("F3"));
        //Debug.Log("z轴向量：" + transform.forward.ToString("F3"));

        //Vector3 face = this.transform.up;

        //GameObject target = GameObject.Find("ball");

        //Vector3 direction = target.transform.position - this.transform.position;

        //float angle = Vector3.Angle(face,direction);

        //this.transform.Rotate(0,0,-angle);

        //int screenW = Screen.width;

        //int screenH = Screen.height;

        //Debug.Log("屏幕:"+screenW + "," + screenH);

        //Vector3 wordPos = transform.position;

        //Vector3 screenPos = Camera.main.WorldToScreenPoint(wordPos);

        //Debug.Log("屏幕坐标"+screenPos);


        transform.eulerAngles = new Vector3(0,0,-90);


	}
	
	// Update is called once per frame
	void Update () {
        //if (upward && transform.position.y > 5) {
        //    upward = false;
        //    transform.localEulerAngles = new Vector3(0,0,180);
        //}
        //if(!upward && transform.position.y < -5){
        //    upward = true;
        //    transform.localEulerAngles = new Vector3(0,0,0);
        //}
        //float step = 1.6f * Time.deltaTime;

        //transform.Translate(0,step,0,Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if(toRight && sp.x > Screen.width){
            toRight = false;
            transform.eulerAngles = new Vector3(0,0,90);
        }
        if (!toRight && sp.x < 0)
        {
            toRight = true;
            transform.eulerAngles = new Vector3(0, 0, -90);
        }

        float step = 1.8f * Time.deltaTime;

        transform.Translate(0,step,0,Space.Self);

	}
}
