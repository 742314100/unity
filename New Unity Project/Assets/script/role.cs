using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class role : MonoBehaviour {

    public int number = 10;

	// Use this for initialization
	void Start () {
        //foreach (Transform child in transform) {
        //    Debug.Log("子节点："+child.name);
        //}

        GameObject obj1 = GameObject.Find("1");
        GameObject target = GameObject.Find("物体");

        obj1.transform.SetParent(target.transform);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
