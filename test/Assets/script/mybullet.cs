using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mybullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float step = 1.8f * Time.deltaTime;
        transform.Translate(0,step,0,Space.Self);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if(sp.y > Screen.height)
        {
            Destroy(this.gameObject);
        }

	}
}
