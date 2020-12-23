using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myjet : MonoBehaviour {

    public GameObject myPrefab;

    //定时
    private float interval = 0.4f; //每隔0.4秒发射一个子弹
    private float count = 0;


    private bool isMouseDown = false;
    private Vector3 lastMousePosition = Vector3.zero;

	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Fire();
        //}

        //计时
        count += Time.deltaTime;
        if(count >= interval)
        {
            count = 0;
            Fire();
        }

        //按键响应

        float step = 2.5f * Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-step,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(step,0,0);
        }

        //手机触屏
        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            lastMousePosition = Vector3.zero;
        }
        if (isMouseDown)
        {
            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                transform.position += offset;
            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


	}

    private void Fire()
    {
        //GameObject bullet = Instantiate(myPrefab);
        //bullet.transform.position = transform.position + new Vector3(0,1f,0);

        Vector3 pos = transform.position + new Vector3(0,1f,0);
        GameObject bullet = Instantiate(myPrefab,pos,transform.rotation);
    }

}
