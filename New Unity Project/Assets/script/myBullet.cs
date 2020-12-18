using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localPosition = new Vector3(0,1.0f,0);


	}
	
	// Update is called once per frame
	void Update () {
        float step = 1.8f * Time.deltaTime;

        transform.Translate(0, step, 0, Space.Self);
	}
}
