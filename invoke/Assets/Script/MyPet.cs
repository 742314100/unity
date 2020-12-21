using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            float distance = (mousePos - transform.position).magnitude;
            if(distance < 2)
            {
                //打中了
                //GameObject main = GameObject.Find("游戏主控");

                //MyGame myGame = main.GetComponent<MyGame>();

                //myGame.AddScore(1);


                GameObject main = GameObject.Find("游戏主控");
                main.SendMessage("AddScore",1);

            }
        }
	}
}
