using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public int speed = 5;

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float y = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.Translate(x,0,y);
	}
}
