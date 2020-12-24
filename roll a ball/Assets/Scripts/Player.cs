using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Rigidbody rd;

    public int force = 5;

    private int score = 0;

    public Text text; //游戏物体中的text

    public GameObject winText; //整个游戏物体

	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal"); //水平
        float v = Input.GetAxis("Vertical"); //垂直

        rd.AddForce(new Vector3(h, 0, v) * force); //按键控制移动
	}
    //碰撞检测
    void OnCollisionEnter(Collision collision)
    {
        //collision.collider //获取碰撞到的游戏物体身上的Collision组件
        //string name = collision.collider.name;
        //print(name);
        if (collision.collider.tag == "PickUp")
        {
            Destroy(collision.collider.gameObject);
        }
    }

    //触发检测
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "PickUp")
        {
            score++;
            text.text = score.ToString();
            if(score == 8)
            {
                winText.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }

}
